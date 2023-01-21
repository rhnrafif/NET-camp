using AppPenjualan.Applications.Transactions.Dto;
using AppPenjualan.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Applications.Transactions
{
    public interface ITransactionAppService
    {
        int Create(CreateTransactionDto model);
        void UpdateTotal(int TransId, int Total);
        PagedResult<TransactionListDto> GetAllTransaction(PageInfo pageInfo);
        PagedResult<TransactionListDto> SearchTransaction(string searchString ,PageInfo pageInfo);
    }
}
