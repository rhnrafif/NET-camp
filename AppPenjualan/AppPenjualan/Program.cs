
//Scaffolding
//1. AppService
//2. Database
//3. Views

//Product : 
//Suplier
//Transaction --> TransaDate , TransaCode
//Transaction Detail --> product yang dibeli
using AppPenjualan;
using AppPenjualan.Applications.ProductServices;
using AppPenjualan.Applications.SupplierServices;
using AppPenjualan.ConfigProfile;
using AppPenjualan.Database;
using AppPenjualan.Views.ProductViews;
using AppPenjualan.Views.ReportViews;
using AppPenjualan.Views.SupplierViews;
using AppPenjualan.Views.TransactionViews;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

class Program
{
    static void Main()
    {
        #region Note Hide

        //var config = new AutoMapper.MapperConfiguration(cfg =>
        //{
        //    cfg.AddProfile(new ConfigurationProfile());
        //});

        //view supplier

        //ISupplierAppService supplierAppService = new SupplierAppService(salesContext, mapper);

        //NOTE :
        //Pakcage Extention Dependecy Inject


        //Dependecy Injection
        // adalah teknik yang mangatur cara bagaimana suatu object
        //SingleTone, Trancient, Scoop
        //SingleTone, objecct di create cuma satu kali, setiap request akan memakai object yang sama
        //Transcient, object akan dicreate setiap kali request untuk dicreate
        //Scope, object sudah di create 1x, tapi berbeda 


        //var serviceProvider = new ServiceCollection();
        //serviceProvider.AddLogging();
        //serviceProvider.AddSingleton<IProductAppService, ProductAppService>();

        //serviceProvider.BuildServiceProvider();

        //dengan mnggunakan dependecy injection
        //IServiceCollection services = new ServiceCollection();
        //Startup startup = new Startup();
        //startup.ConfigureServices(services);
        //IServiceProvider serviceProvider = services.BuildServiceProvider();

        ////product view
        //var productView = serviceProvider.GetService<ProductViews>();
        //var supplierView = serviceProvider.GetService<SupplierViews>();

        #endregion



        Startup startup = new Startup();
        var productView = startup.Provider.GetService<ProductViews>();
        var tranView = startup.Provider.GetService<TransactionViews>();
        var supplierView = startup.Provider.GetService<SupplierViews>();
        var reportView = startup.Provider.GetService<ReportView>();

        bool showMenu = true;
        while (showMenu)
        {
            Console.Clear();
            Console.WriteLine("Point of Sales EnigmaCamp");
            Console.WriteLine("===========================");
            Console.WriteLine("Choose An Option");
            Console.WriteLine("1. Products");
            Console.WriteLine("2. Supliers");
            Console.WriteLine("3. Transactions");
            Console.WriteLine("4. Reports");
            Console.WriteLine("5. Exit");
            Console.Write("Select an Option : ");

            switch (Console.ReadLine())
            {
                case "1":
                    ////view
                    //IMapper mapper = config.CreateMapper();
                    //SalesContext salesContext = new SalesContext();
                    //IProductAppService productAppService = new ProductAppService(salesContext, mapper);
                    //var productMenu = new ProductViews(productAppService);
                    //productMenu.DisplayView();

                    productView.DisplayView();
                    showMenu = true;
                    break;
                case "2":
                    //view
                    //var supplierMenu = new SupplierViews(supplierAppService);
                    //supplierMenu.DisplayView();
                    supplierView.DisplayView();
                    showMenu = true;
                    break;
                case "3":
                    //view
                    tranView.DisplayView();
                    showMenu = true;
                    break;
                case "4":
                    //view
                    reportView.DisplayView();
                    showMenu = true;
                    break;
                case "5":
                    //view
                    showMenu = false;
                    break;
                default:
                    //view
                    showMenu = true;
                    break;
            }


        }
    }
}