/*
 //NAMESPACE
 - PascalCase forName : AppProductSevice
 - Use Noun for nameSpace
 - Use Plural word for namespace
 - dont use underScore for nameSpace
 - dont exceed out 100 char for name
 
//CLASS
 - use Pascal Case fro className
 - use Noun fro className
 - use singular word for ClassName. ex ; public class UserService(){}
 - use vertically allign curlybrace
 - dont use underscore for classname

//INTERFACE
 - use Pascal Case for Interface
 - use Noun name for Interface
 - prefix interface name with letter "I"
 - use vertically allign curlybrace
 - dont use undescrore for interface
 - dont exceed out 100 char for name

//Constant
 - use PascalCase for constant : ex BaseUrl = "url";
 - use Noun for Constant Name
 - use MeaningFul fro Constant name : ex : UserConfig instead of UsrCfg;
 - use predefine name (int, string, float) insetad of .net type (String, Int32)
 - Dont use underscore for constant name
 - Dont use SCREAMING case for Constant (UPPERCASE)
 - use common abrevation (jangan disingkat)
 - dont exceed out 50 char for name

//FIELD
 - use CamleCase for private field name
 - use PascalCase for public field name
 - use MeaningFul fro Field name : ex : public UserSevice instead of UsrSvc;
 - use predefine name (int, string, float) insetad of .net type (String, Int32)
 - make field readlonly if possible
 - use common abrevation (jangan disingkat)
 - dont exceed out 50 char for name

//Property
 - use PascalCase for Property Name
 public string FirstName {get;set;}

 - use noun for property name
 - use MeaningFul fro Property name
 - use predefine name (int, string, float) insetad of .net type (String, Int32)

//Method
 - use PascalCase for Method Name
 - use verb for method name
 - use vertically curly braces
 - dont exceed out 50 char for name

//Method Arguments (parameternya)
 - use camelCase for method args
 - user noun for method arguments
 - use predefine name (int, string, float) insetad of .net type (String, Int32)
 - dont use underscore for method arguments
 - dont exceed out 50 char for name

//Local Variable
 - use camelcase for variable name
 - use noun for variable name
 - use meaningful word
 - use predefine name (int, string, float) insetad of .net type (String, Int32)
 - use common abrevation (jangan disingkat)
 - dont use underScore
 - dont exceed out 50 char for name

//ENUM
 - use PascalCase
 - use noun for Enum name
 - use singular word for Enum Name
 - dont use ennum ass suffix(imbuhan belakang)
 - dont use underscore for enum name


SOLID.

SRP (Single Responsibility Principles)

Open/Close Principle
"Software entities (classes, modules, functions etc) should be open for extension but closed for modification."

Open for extension
---> Module bisa di extend. Maksudnya adalah jika requirement membutuhkan aplikasi untuk di ubah maka modul bisa di sesuaikan engan perubahan tsb.

Closed for modification
Module entities etc itu hanya di ubah ketika
ada bugs, sehingga aplikasi yg sudah lulus Unit testing jangan di ubah atau akan mengganggu fungsi yg lain.

Misalnya, kita punya module invoice. Invoice ini biasanya terbagi menjadi 2 tipe, 1 untuk pribadi, 2 untuk company.

public class InvoiceService: IInvoiceService
{
  //...
  public async Task Sign(int orderId)
  {
    var order = await order.getbyid(orderId);
    var invoiceId = order.InvoiceId;
    var invoice = await GetInvoiceByType(order, invoiceId);

  switch(order.type)
  {
    case ordertype.company
      // method company
    case ordertype.personal
      // method personal
  }
  }
  
  //...

public async Task Export(int orderId)
{
  // todo
  return invoice?.Export();
}
} 

public abstract class InvoiceBase : EntityBase
{
  public Order Order{get;set;}
        public abstract string Sign();
  
  protected InvocieBase(Order order)
  {
    Order = order;  
  }
}

public class CompanyInvoice: InvoiceBase
{
  public int TaxNumber{get;set;}
  // Constructor
  public CompanyInvoice(Order order, int taxNumber): base(order)
  {
    TaxNumber = taxNumber;
  }
  
  public override string Sign()
  {
    // todo sign
  }
}

public class PersonalInvoice: InvoiceBase
{
  public PersonalInvoice(Order order): base(order)
  {
    
  }
  
  public override string Sign()
  {
    // todo sign
  }

  public override string Export(0
  {
    // todo export
  }
}

Closed for Modifications

public class InvoiceService: IInvoiceService
{
  public async Task Sign(int orderId)
  {
    var order = await order.getbyid(orderId);
    var invoiceId = order.InvoiceId;
    var invoice = await GetInvoiceByType(order, invoiceId);

    invoice?.Sign();
  }
}

Liskov Substitution Principle
"You should be able to use any derived class instead of a parent class and have it behave the same manner without modification"

public abstract class InvoiceBase : EntityBase
{
  public Order Order{get;set;}
        public abstract string Sign();
  
  protected InvoiceBase()
  {

  }  

  protected InvocieBase(Order order)
  {
    Order = order;  
  }

  public virtual string Export()
  {
    return $"Export invoice here";
  }
}

public class CompanyInvoice: InvoiceBase
{
  public int TaxNumber{get;set;}
  // Constructor
  public CompanyInvoice(Order order, int taxNumber): base(order)
  {
    TaxNumber = taxNumber;
  }
  
  public override string Sign()
  {
    // todo sign
  }

  public override string Export()
  {
    return $"Derived export for Company";
  }
}

Interface Segregation Principle
"Clients should not be force to implement interfaces they dont use. instead of one fat interface, many small interfaces are preferred based on groups of functions, each one service one submodule."

public interface IPayment
{
  void Pay(int amount);
  void ScanQRCode();
  void PayViaEWalletOrBank(); <--- SALAH
  // payment via Bank
  void AddBankInfo();
  void PayWithInstallment()
  // payment via ewallet
  void LinkToBank();
  void Topup();
}

// Payment
public interface IPayment
{
  void Pay(int amount);
  void ScanQRCode();
}
// BANK
public interface IBankPayment: IPayment
{
  void AddBankInfo();
  void PayWithInstallment()
}
// EWallet
public interface IEWalletPayment: IPayment
{
  void LinkToBank();
  void Topup();
}

// Implement Bank Payment
public class BankPayment: IBankPayment
{
  public void Pay(int amount)'
  {
  
  }
  
  public void ScanQRCode()
  {
  
  }

  public void BankInfo()
  {
  
  }

      public void PayWithInstallment()
  {
  
  }
}

// Implement Ewallet Payment
public class EWalletPayment: IEWalletPayment
{
  public void Pay(int amount)'
  {
  
  }
  
  public void ScanQRCode()
  {
  
  }

  public void LinkToBank()
  {
  
  }

public void TopUp()
  {
  
  }
}

Dependency Inversion Principles
* High level modules should not depend on low level module. both should depen on abstraction (interface)

* Abstraction should not depend upon details. Details should depend on abstraction

IPayment
IBankPayment
IEWalletPayment

public class BankPaymentService: IBankPayment
{
  // todo
}


public class BankPaymentController: ControllerBase
{
  private readonly BankPaymentService _bankPaymentService; <--- akses service dan ini salah
  private readonly IBankPayment 
  public BankPaymentController(BankPaymentService bankPaymentService)
  {
    _bankPaymentService = bankPaymentService;
  }
}


C# Coding Conventions.
Namespace
* PascalCase for Namespace
// Cara yang salah
namespace EnigmaCamp.application.services;

// Cara yg benar
namespace EnigmaCamp.Application.Services;

* Use noun for Namespace
// Cara yg salah
namespace EnigmaCamp.Application.CreateEntity;

// Cara yg benar
namespace EnigmaCamp.Application.Entities;

* Use plural word for Namespace
// Cara yg benar
namespace EnigmaCamp.Application.Entities;
// Cara yg benar
namespace EnigmaCamp.Application.Services;

//Cara yg salah
namespace EnigmaCamp.Application.Entity;
// Cara yg salah
namespace EnigmaCamp.Application.Service;

*Dont use underscore for namespace
*Dont exceed 100 characters length for namespace

Class
*Use PascalCase for class name
public class UserService // benar

public class userservice // Salah

*use noun for class name
public class DataInitializer // Benar

public class InitializerData // Salah

*Use singular word for class name
public class UserService // benar

public class UserServices // salah

*user vertically aligned curly brackets
public class UserService // benar
{

}

public class UserService { // salah

}

*Dont use underscore for class name 
public class UserService // benar

public class User_Service // salah

* Dont exceed 100 characters for class name

Interface
*Do user PascalCase for Interface Name
public interface IUserService // benar
public interface iuserservice // salah

*use noun for interface name
public interface IDataGenerator // benar
public interface IGeneratorData // salah

*use prefix interface with letter "I"
public interface IUserService //benar
public interface UserService //salah

*user vertically aligned curly brackets
public interface IUserService //Benar
{

}

public interface IUserService{ // Salah

}
*Dont use underscore for interface name
public interface IUserService //Benar
{

}

public interface IUser_Service{ // Salah

}

*dont exceed 100 characters length for interface name

Constant
*use PascalCase for constant name
public class string BaseUrl = "url"; // benar
public class string baseurl = "url"; // salah

*use noun for constant name
public const bool IsRunning = true; // benar
public const bool Run = true;// salah

*use meaningful words for constant name
public const string UserConfig = "UserConfig"; // benar

public const string UsrCfg = "UsrCfg"; // salah


* use predefined type name (int, string, float etc) instead of .Net Type (Int32, String, Single) for constant declarations
public string BaseUrl ="BaseUrl"; // benar
public String BaseUrl = "BaseUrl"; //salah

* Dont user underscore for constant name
public string BaseUrl ="BaseUrl"; // benar
public String Base_Url = "BaseUrl"; //salah

*Dont use SCREAMINGCASE 
public string BaseUrl ="BaseUrl"; // benar
public String BASEURL = "BaseUrl"; //salah

*use common abreviations for constant name
public string BaseUrl ="BaseUrl"; // benar
public String BsUrl = "BaseUrl"; //salah

*dont exceed 50 characters for constant name


Field
use camelCase for private field name
private int _age = 20; // Benar
private int Age = 20; // salah

use PascalCase for Public field name
public int _age = 20; // salah
public int Age = 20; // Benar

*use meaningful words for field name
public readonly IUserService _userService; // benar

public readOnly IUserService _usrSvc; // salah

*use predefined type name instead .NET Type
private int _age = 20; // benar
private Int32 _age = 20; // salah

*make field readonly if possible
*use common abreviations for field name
priavte readonly int _usrMaxLmt = 10; //salah
private readonly in _userMaxLimit = 10; // benar

* dont exceed 50 characters length for field name

Property

*use PascalCase for property name
public string FirstName {get;set;} //benar
public string first_name{get;set;} //salah


*use noun for property name
public bool IsDeleted{get;set;} //benar
public bool Delete{get;set;} // salah

*use meaningful word for property name
public string FirstName{get;set;} // benar
public string FN{get;set;} // salah

*use predefined type name
public int Weight {get;set;} // benar
public Int32 Weight{get;set;} // salah

*use common abreviations for propertyname
public string UserName {get;set;} //benar
public string UsrNm {get;set;}//salah
public string strUserName {get;set;} //salah

*dont exceed 50 characters length for property name

Method
*Use PascalCase for method name
public void CreateUser(string userName) // benar

public void createUser(string username) // salah

*use verb for method name
public void CreateUser(string userName) // benar

public void UserCreator(string userName) // salah

*use vertically curly brackets
public void CreateUser(string userName) // benar
{
}

public void CreateUser(string userName){ // salah
}

*dont use underscore for methodname
public void CreateUser(string userName)
{
} // benar

public void Create_User(string userName)
{
} //salah

*dont exceed 50 characters length for methodname

Method Arguments
*use camelCase for method args
public void CreateUser(string userName)
{
} // benar

public void CreateUser(string first_name)
{
}//salah

*use noun for method arguments
public void Delete (int deletedId) // benar
public void Delete (int deleteId) // salah

*use predefined type name instead of .NET Type
public void CalculateBonus(int age, float salary) // benar

public void CalculateBonus(Int32 age, Single salary) // salah

*use common abbreviations for method args
public void Delete (int deletedId);// benar
public void Delete (int delId); // salah

*dont use underscore for method args
public void Delete (int deletedId) //benar
public void Delete (int deleted_Id) // salah

*dont exceeds 50 characters length for method args


Local Variables
*use camelCase for variable name
var firstName = "Anton"; // benar
var FirstName = "Anton"; // salah
var first_name = "Anton"; // salah

*use noun for variable name
var created = true; // benar
var create = true; // salah

*use meaningful words for variable name
var customerTotalSales = 100; // benar
var custToSls = 100; // salah

*use predefined type name instead of .NET Type
int salary; // benar
Int32 salary; // salah

*use common abbr for variable name
var csvPath = "path"; // benar
var maxLmt = 100; // salah

*dont use underscore for variable name
var csvPath = "path"; // benar
var csv_Path = "path"; // salah
*dont exceeds 50 characters length for variable name

Enum
*use PascalCase for enum name
public enum SalesOrderStatus // benar
{
// enum
}

public enum salesOrderStatus // salah

*use noun for enum name
public enum Gender // benar
public enum GetGender // salah

*use singular word for enum name
public enum Status // benar
public enum Statuses // salah

*dont use enum as suffix
public enum Gender // benar
public enum GenderEnum // salah

*dont use underscore for enum
public enum SalesOrderStatus // benar
public enum Sales_Order_Status // salah
*dont excee 50 characters length for enum name 


SOLID Principles
KISS (Keep It Simple Stupid)
DRY (DONT REPEAT YOURSELF)
YAGNI (You arent gonna need it) // Jangan bikin method/function yg kita ga butuhin.)
GetDateHoliday() <--- Klo ini gak perlu jangan di bikin.
 
 */