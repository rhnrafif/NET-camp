using AppPenjualan.Applications.ProductServices;
using AppPenjualan.Applications.SupplierServices;
using AppPenjualan.Applications.TransactionDetailServices;
using AppPenjualan.Applications.Transactions;
using AppPenjualan.ConfigProfile;
using AppPenjualan.Database;
using AppPenjualan.Views.ProductViews;
using AppPenjualan.Views.ReportViews;
using AppPenjualan.Views.SupplierViews;
using AppPenjualan.Views.TransactionViews;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPenjualan
{
    public class Startup
    {
        IConfigurationRoot Configuration { get;}
        public IServiceProvider Provider { get; }
       
        public Startup()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false);
            Configuration = builder.Build();
            Provider = ConfigureService();

        }

        private IServiceProvider ConfigureService()
        {
            var services = new ServiceCollection();
            //setting automapper
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ConfigurationProfile());
            });


            var mapper = config.CreateMapper();

            //assign automapper to dependecy injection
            services.AddSingleton(mapper);

            //settings of dependency injection

            services.AddLogging();
            services.AddSingleton<IConfigurationRoot>(Configuration);

            //Create Service
            services.AddSingleton<IProductAppService, ProductAppService>();
            services.AddSingleton<ISupplierAppService, SupplierAppService>();
            services.AddSingleton<ITransactionAppService, TransactionAppService>();
            services.AddSingleton<ITransactionDetailAppService, TransactionDetailAppService>();

            //Create DB Context
            services.AddDbContext<SalesContext>(option =>
            {
                option.UseSqlServer(Configuration.GetConnectionString("DBConnection"), builder =>
            builder.MigrationsAssembly("migration.presentence"));
            }, ServiceLifetime.Singleton);

            //view yang akan dipakai di dep injection
            //semua view dimasukan disini

            //products
            services.AddSingleton<UpdateProductView>();
            services.AddSingleton<DeleteProductView>();
            services.AddSingleton<CreateProductView>();
            services.AddSingleton<GetAllProductList>();
            services.AddSingleton<SearchProductView>();
            services.AddSingleton<ProductViews>();

            //supplier
            services.AddSingleton<CreateSupplierView>();
            services.AddSingleton<UpdateSupplierView>();
            services.AddSingleton<DeleteSupplierView>();
            services.AddSingleton<GetAllSupplierView>();
            services.AddSingleton<SupplierViews>();

            //transaction
            services.AddSingleton<CreateTransactionView>();
            services.AddSingleton<SearchTransactionView>();
            services.AddSingleton<TransactionViews>();

            services.AddSingleton<ReportView>();


            return services.BuildServiceProvider();
        }
    }
}
