using AppPenjualan.Applications.SupplierServices.Dto;
using AppPenjualan.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Applications.SupplierServices
{
    public interface ISupplierAppService
    {
        void CreateSupplier(CreateSupplierDto model);
        void UpdateSupplier(UpdateSupplierDto model, string name);
        void DeleteSupplier(int id);
        List<SupplierListDto> GetAllSupplier();
        UpdateSupplierDto GetSupplierByName(string name);
    }
}
