using AppPenjualan.Applications.ProductServices.Dto;
using AppPenjualan.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Applications.ProductServices
{
    public interface IProductAppService
    {
        void Create(CreateProductDto model);
        void Update(UpdateProductDto model);
        void Delete(int id);
        PagedResult<ProductListDto> GetAllProducts(PageInfo pageInfo);
        UpdateProductDto GetProductByCode(string code);

        PagedResult<ProductListDto> SearchProduct(string serachString, PageInfo pageInfo);


    }
}
