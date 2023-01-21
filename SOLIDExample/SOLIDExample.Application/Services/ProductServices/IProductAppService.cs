using SOLIDExample.Entity.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExample.Application.Services.ProductServices
{
    public interface IProductAppService
    {
        Task<Product> GetById(int id);
        Task<Product> Add(Product product);
        Task Remove(int id);

    }
}
