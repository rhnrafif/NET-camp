using AppPenjualan.Applications.TransactionDetailServices.Dto;
using AppPenjualan.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Applications.TransactionDetailServices
{
    public interface ITransactionDetailAppService
    {
        void Create(CreateTransactionDetailDto model);
        void Update(UpdateTransactionDetailDto model);
        void Delete(int id);
        List<TransactionDetailDto> GettransactionDetail(int TransactionId);
    }
}
