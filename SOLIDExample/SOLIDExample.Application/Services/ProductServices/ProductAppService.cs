using SOLIDExample.Application.SeedWorks;
using SOLIDExample.Entity.Entities.Products;
using SOLIDExample.Infrastructure.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Application.Services.ProductServices
{
    public class ProductAppService : BaseService, IProductAppService
    {
        private readonly IRepository<Product> _productRepo;

        public ProductAppService(IUnitOfWorks unitOfWork, 
            IRepository<Product> productRepo) : base(unitOfWork)
        {
            _productRepo = productRepo;
        }

        public async Task<Product> Add(Product product)
        {
           _productRepo.Add(product);
            await UnitOfWork.SaveChangesAsync();

            return product;
        }

        public async Task<Product> GetById(int id)
        {
            return await _productRepo.GetAsync(id);
        }

        public async Task Remove(int id)
        {
            var product = await _productRepo.GetAsync(id);
            if(product != null)
            {
                _productRepo.Delete(product);
                await UnitOfWork.SaveChangesAsync();
            }
        }
    }
}
