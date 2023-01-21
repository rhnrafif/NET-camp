using AppPenjualan.Applications.ProductServices.Dto;
using AppPenjualan.Applications.SupplierServices.Dto;
using AppPenjualan.Applications.TransactionDetailServices.Dto;
using AppPenjualan.Applications.Transactions.Dto;
using AppPenjualan.Database;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan.ConfigProfile
{
    public class ConfigurationProfile : Profile
    {
        public ConfigurationProfile()
        {
            CreateMap<Products, CreateProductDto>();
            CreateMap<CreateProductDto, Products>();

            CreateMap<Products, UpdateProductDto>();
            CreateMap<UpdateProductDto, Products>();

            CreateMap<Products, ProductListDto>();
            CreateMap<ProductListDto, Products>();

            CreateMap<Suppliers, CreateSupplierDto>();
            CreateMap<CreateSupplierDto, Suppliers>();

            CreateMap<Suppliers, UpdateSupplierDto>();
            CreateMap<UpdateSupplierDto, Suppliers>();

            CreateMap<Suppliers, SupplierListDto>();
            CreateMap<SupplierListDto, Suppliers>();

            CreateMap<Transactionns, CreateTransactionDto>();
            CreateMap<CreateTransactionDto,Transactionns>();

            CreateMap<TransactionDetails, CreateTransactionDetailDto>();
            CreateMap<CreateTransactionDetailDto, TransactionDetails>();

            CreateMap<TransactionDetails, UpdateTransactionDetailDto>();
            CreateMap<UpdateTransactionDetailDto,TransactionDetails>();

            CreateMap<TransactionDetails, TransactionDetailDto>();
            CreateMap<TransactionDetailDto, TransactionDetails>();
        }
        
    }
}
