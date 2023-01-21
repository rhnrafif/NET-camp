using AppPenjualan.Applications.TransactionDetailServices.Dto;
using AppPenjualan.Database;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Applications.TransactionDetailServices
{
    public class TransactionDetailAppService : ITransactionDetailAppService
    {
        private readonly SalesContext _salesContext;
        private IMapper _mapper;
        public TransactionDetailAppService(SalesContext salesContext, IMapper mapper)
        {
            _salesContext = salesContext;
            _mapper = mapper;

        }

        public void Create(CreateTransactionDetailDto model)
        {
            var transDetail = _mapper.Map<TransactionDetails>(model);
            _salesContext.TransactionDetails.Add(transDetail);
            _salesContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var transDetail = _salesContext.TransactionDetails.FirstOrDefault(w => w.TransactionDetailId == id);
            if(transDetail != null)
            {
                _salesContext.TransactionDetails.Remove(transDetail);
                _salesContext.SaveChanges();
            }
        }

        public List<TransactionDetailDto> GettransactionDetail(int TransactionId)
        {
            var transactionDetailList = _salesContext.TransactionDetails.ToList();
            var transDetailDto = _mapper.Map<List<TransactionDetailDto>>(transactionDetailList);
            return transDetailDto;
        }

        public void Update(UpdateTransactionDetailDto model)
        {
            var transDetail = _mapper.Map<TransactionDetails>(model);
            _salesContext.TransactionDetails.Update(transDetail);
            _salesContext.SaveChanges();
        }
    }
}
