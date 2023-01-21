using AppPenjualan.Applications.Transactions.Dto;
using AppPenjualan.Database;
using AppPenjualan.Helpers;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Applications.Transactions
{
    public class TransactionAppService : ITransactionAppService
    {
        private readonly SalesContext _salesContext;
        private IMapper _mapper;
        public TransactionAppService(SalesContext salesContext, IMapper mapper)
        {
            _salesContext = salesContext;
            _mapper = mapper;
        }

        public int Create(CreateTransactionDto model)
        {
            var transaction = _mapper.Map<Transactionns>(model);
            transaction.TransactionCode = AutoGenerate();

            _salesContext.Transactionns.Add(transaction);
            _salesContext.SaveChanges();
            _salesContext.Entry(transaction).GetDatabaseValues();
            int id = transaction.TransactionsId;
            return id;
        }

        public PagedResult<TransactionListDto> GetAllTransaction(PageInfo pageInfo)
        {
            var pageResult = new PagedResult<TransactionListDto>()
            {
                Data = (from transaction in _salesContext.Transactionns
                        select new TransactionListDto
                        {
                            TransactionCode = transaction.TransactionCode,
                            TransactionDate = transaction.TransactionDate,
                            Total = transaction.Total,
                            Description = transaction.Description
                        }),
                Total = _salesContext.Transactionns.Count()
            };
            
            return pageResult;

        }

        public PagedResult<TransactionListDto> SearchTransaction(string searchString, PageInfo pageInfo)
        {
            var transactions = from transaction in _salesContext.Transactionns
                              select transaction;
            var pagedResult = new PagedResult<TransactionListDto>()
            {
                Data = (from transaction in transactions
                        select new TransactionListDto
                        {
                            TransactionCode = transaction.TransactionCode,
                            TransactionDate = transaction.TransactionDate,
                            Total = transaction.Total,
                            Description = transaction.Description
                        })
                        .Skip(pageInfo.Skip)
                        .Take(pageInfo.PageSize)
                        .OrderBy(w => w.TransactionCode),
                Total = _salesContext.Products.Count()
            };

            return pagedResult;

        }

        public void UpdateTotal(int TransId, int Total)
        {
            var transaction = _salesContext.Transactionns.FirstOrDefault(w => w.TransactionsId == TransId);

            transaction.Total = Total;

            _salesContext.Transactionns.Update(transaction);
            _salesContext.SaveChanges();
        }

        private string AutoGenerate()
        {
           

            int num = _salesContext.Transactionns.Where(w => w.TransactionDate == DateTime.Now).Count();
            string runningNo = Convert.ToString(num + 1).PadLeft(3, '0');
            string code = "TR-" + DateTime.Now.ToString("ddMM") + runningNo;

            return code;
        }
    }
}
