using AppPenjualan.Applications.ProductServices.Dto;
using AppPenjualan.Database;
using AppPenjualan.Helpers;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.Applications.ProductServices
{
    public class ProductAppService : IProductAppService
    {
        private readonly SalesContext _salesContext;
        private IMapper _mapper;
        public ProductAppService(SalesContext salesContext, IMapper mapper)
        {
            _salesContext = salesContext;
            _mapper = mapper;
        }
        public PagedResult<ProductListDto> GetAllProducts (PageInfo pageInfo)
        {
            var pagedResult = new PagedResult<ProductListDto>
            {
                Data = (from product in _salesContext.Products //JOIN
                        join supplier in _salesContext.Suppliers
                            on product.SuppliersId equals supplier.SuppliersId
                        select new ProductListDto //select sesuai filed yg ada di DTO
                        {
                            ProductName = product.ProductName,
                            ProductCode = product.ProductCode,
                            ProductPrice = product.ProductPrice,
                            ProductQty = product.ProductQty,
                            SupplierName = supplier.SupplierName

                        })
                        .Skip(pageInfo.Skip)
                        .Take(pageInfo.PageSize)
                        .OrderBy(w => w.ProductCode),
                Total = _salesContext.Products.Count()

            };

            return pagedResult;
        }

        public void Create(CreateProductDto model)
        {
            var product = _mapper.Map<Products>(model);
            _salesContext.Products.Add(product);
            _salesContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = _salesContext.Products.FirstOrDefault(w => w.ProductsId == id);

            if(product != null)
            {
                _salesContext.Products.Remove(product);
                _salesContext.SaveChanges();
            }
        }

        public void Update(UpdateProductDto model)
        {
            var product = _mapper.Map<Products>(model);
            _salesContext.Products.Update(product);
            _salesContext.SaveChanges();
        }

        public UpdateProductDto GetProductByCode(string code)
        {
            var product = _salesContext.Products.FirstOrDefault( w => w.ProductCode == code);
            var productDto = _mapper.Map<UpdateProductDto>(product);
            return productDto;
        }

        public PagedResult<ProductListDto> SearchProduct(string serachString, PageInfo pageInfo)
        {
            var products = from product in _salesContext.Products
                          select product;

            if (!String.IsNullOrEmpty(serachString))
            {
                products = products.Where(s => s.ProductName.Contains(serachString)
                || s.ProductCode.Contains(serachString));
            }

            var pagedResult = new PagedResult<ProductListDto>
            {
                Data = (from product in products
                        join supplier in _salesContext.Suppliers
                            on product.SuppliersId equals supplier.SuppliersId
                        select new ProductListDto
                        {
                            ProductCode = product.ProductCode,
                            ProductName = product.ProductName,
                            ProductPrice = product.ProductPrice,
                            ProductQty = product.ProductQty,
                            SupplierName = supplier.SupplierName
                        })
                        .Skip(pageInfo.Skip)
                        .Take(pageInfo.PageSize)
                        .OrderBy(w => w.ProductCode),
                Total = _salesContext.Products.Count()
            };
            return pagedResult;
        }
    }
}
