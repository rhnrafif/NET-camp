using AppPenjualan.Applications.SupplierServices.Dto;
using AppPenjualan.Database;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Applications.SupplierServices
{
    public class SupplierAppService : ISupplierAppService
    {
        private readonly SalesContext _salesContext;
        private IMapper _mapper;
        public SupplierAppService(SalesContext salesContext, IMapper mapper)
        {
            _salesContext = salesContext;
            _mapper = mapper;
        }

        public void CreateSupplier(CreateSupplierDto model)
        {
            var supplier = _mapper.Map<Suppliers>(model);
            _salesContext.Suppliers.Add(supplier);
            _salesContext.SaveChanges();
            
        }

        public void DeleteSupplier(int id)
        {
            var supplier = _salesContext.Suppliers.FirstOrDefault(w => w.SuppliersId == id);
            if(supplier != null)
            {
                _salesContext.Suppliers.Remove(supplier);
                _salesContext.SaveChanges();
            }
        }

        public List<SupplierListDto> GetAllSupplier()
        {
            var supplierList = _salesContext.Suppliers.ToList();
            var supplierListDto = _mapper.Map<List<SupplierListDto>>(supplierList);
            return supplierListDto;
        }

        

        public UpdateSupplierDto GetSupplierByName(string name)
        {
            var supplier = _salesContext.Suppliers.FirstOrDefault(w => w.SupplierName.ToLower() == name.ToLower());
            var supplierName = _mapper.Map<UpdateSupplierDto>(supplier);

            return supplierName;
        }

        public void UpdateSupplier(UpdateSupplierDto model, string name)
        {
            //var supplier = _mapper.Map<Suppliers>(model);
            
            var supUpdate = _salesContext.Suppliers.FirstOrDefault(w => w.SupplierName == name);

            supUpdate.SupplierName = model.SupplierName;
            supUpdate.SupplierAddress = model.SupplierAddress;
            
            

            _salesContext.Update(supUpdate);
            _salesContext.SaveChanges();
        }
    }
}
