using Day13.Applications.Employees;
using Day13.SqlServices;
using Day13.Views;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Data;
using System.Data.SqlClient;

class Program
{
    // SqlConnection = untuk mengkoneksikan program ke database
    // Sql Command = melakukan / menginputkan query tertentu yang akan dieksekusi oleh ExecuteNonQuery atau SqlDataReader
    // ExecuteNonQuery = digunakan untuk melakukan query tanpa mengembalikan apapun, misalnya : INSERT, UPDATE, DELETE
    // sqlDataReader = digunakan untuk melakukan query dengan mengembalikan nilai tertentu, misalnya SELECT
    //SQL Data Adapter
    
    static void Main()
    {

        //var connectionString = "Server=RHNRAFIF\SQLEXPRESS;Database=ShipDB;Trusted_Connection=True;";

        var connStr = ConfigurationManager.ConnectionStrings["ShipDB"].ConnectionString;
        SqlConnection _sqlConnection = new SqlConnection(connStr);

        var empAppService = new EmployeeAppService(_sqlConnection);

        bool showMenu = true;
        while (showMenu)
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Create Employee");
            Console.WriteLine("2) Update Employee");
            Console.WriteLine("3) Get Employee By Id");
            Console.WriteLine("4) Get All Employee");
            Console.WriteLine("5) Delete Employee");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    var createView = new CreateEmployeeView(empAppService);
                    createView.DisplayView();
                    showMenu = true;
                    break;
                case "2":
                    Console.Clear();
                    var updateView = new UpdateEmployeeView(empAppService);
                    showMenu = true;
                    break;
                case "3":
                    Console.Clear();
                    var getAllView = new GetAllEmployeeView(empAppService);
                    getAllView.DisplayView();
                    showMenu = true;
                    break;
                case "4":
                    Console.Clear();
                    empAppService.GetAllEmployee();
                    showMenu = true;
                    break;
                case "5":
                    Console.Clear();
                    empAppService.GetAllEmployee();
                    showMenu = true;
                    break;
                case "6":
                    showMenu = false;
                    break;
                default:
                    showMenu = true;
                    break;
            }
        }

    }

    //NOTE HARI KE 14,
    //STEP MEMBUAT DTO
    // 1. Membuat Model -- representasi dari tabel database
    // 3. Membuat DTO, yakni field tabel mana saja yang akan di lihat oleh user
    // 2. Membuat Interface -- represntasi service yang akan di buat.
    // Bisa memuat DTO didalamnya, disarankan untuk membuat DTO terlebih dahulu.
    // bisa juga memuat beberapa parameter dalam methodnya untuk di oper ke service agar bisa digunakan di service
    //
    // 4. membuat Services -- mengimplementsasi dari Interface, bisa juga DTO.
    // karena diInterface bisa saja merepresntasikan DTO dalam Servicenya.
    // Di service juga lah connection antara database / tabel dicreate.
    //
    // 5. Membuat Views, yakni tampilan Console untuk menjalan service yang ada.
    // Ada konstruktor sebagai penghubung antara views dan interface(agar method service didalmnya bisa akses) 



    //    //string untuk koneksi server
    //    public static string conString = "Server=RHNRAFIF\\SQLEXPRESS;Database=ShipDB;Trusted_Connection=True;";
    //    //static void Main()
    //    //{

    //    //    try
    //    //    {

    //    //        Console.WriteLine("Before Transaction");
    //    //        GetAccountBalance();
    //    //        MoneyTransfer();
    //    //        Console.WriteLine("After Transaction");
    //    //        GetAccountBalance();


    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        Console.WriteLine($"An error occured {ex.Message}");
    //    //    }

    //    //}
    //    private static void MoneyTransfer()
    //    {
    //        using (SqlConnection sqlConnection = new SqlConnection(conString))
    //        {
    //            sqlConnection.Open();

    //            SqlTransaction transaction = sqlConnection.BeginTransaction();
    //            try
    //            {
    //                SqlCommand cmd = new SqlCommand("UPDATE Accounts SET Balance = Balance - 900 WHERE AccountNumber = 'Account1'", sqlConnection);
    //                cmd.Transaction = transaction;
    //                cmd.ExecuteNonQuery();

    //                cmd = new SqlCommand("UPDATE Accounts SET Balance = Balance + 1000 WHERE AccountNumber = 'Account2'", sqlConnection);
    //                cmd.Transaction = transaction;
    //                cmd.ExecuteNonQuery();

    //                transaction.Commit();
    //                Console.WriteLine("Transaction Comitted Succesfully");
    //            }
    //            catch (DbException dbe)
    //            {
    //                transaction.Rollback($"An Error Occured {dbe.Message}");

    //            }
    //        }
    //    }
    //    private static void GetAccountBalance()
    //    {
    //        SqlConnection sqlConnection = new SqlConnection(conString);

    //        SqlCommand cmd = new SqlCommand("SELECT * FROM Accounts", sqlConnection);
    //        sqlConnection.Open();
    //        SqlDataReader sr = cmd.ExecuteReader();

    //        while (sr.Read())
    //        {
    //            Console.WriteLine($"{sr["AccountNumber"]} - {sr["Balance"]}");
    //        } 

    //    }
    //    static void Conect()
    //    {
    //        //mengkoneksikan ke database
    //        SqlConnection conn = null; //deklarasi connecsi ADO
    //        try
    //        {

    //            //koneksikan ke database, dengan  nama server, nama database, dan autentication
    //            //jika menggunakan user dan password
    //            //Server=MySQL;Initial Catalog=DatabaseNya;User ID=*****;Password=*******;Persist Security=False;
    //            conn = new SqlConnection(@"Server=RHNRAFIF\SQLEXPRESS;Database=ShipDB;Trusted_Connection=True;");
    //            conn.Open(); //membuka koneksi ke database
    //            Console.WriteLine("Connection Succes");
    //        }
    //        catch (DbException dbex)
    //        {
    //            Console.WriteLine($"Error Accured {dbex.Message}");
    //        }
    //        finally
    //        {
    //            conn.Close();
    //            Console.WriteLine("Connection Closed");
    //        }
    //    }
    //    static void Insert()
    //    {
    //        //mengkoneksikan ke database
    //        SqlConnection conn = null; //deklarasi connecsi ADO
    //        try
    //        {

    //            conn = new SqlConnection(@"Server=RHNRAFIF\SQLEXPRESS;Database=ShipDB;Trusted_Connection=True;");

    //            //Buat SQL Command membuat tabel
    //            SqlCommand cmd = new SqlCommand(@"INSERT INTO Student (StudentId, Name) VALUES (3, 'Riska')", conn);

    //            conn.Open(); //membuka koneksi ke database
    //            cmd.ExecuteNonQuery(); //mengekseskusi query diatas
    //            //ExecuteNonwwuery digunakan untuk query INSERT, UPDATE, DELETE.
    //            Console.WriteLine("Connect and Insert Record Succesfully");
    //        }
    //        catch (DbException dbex)
    //        {
    //            Console.WriteLine($"Error Accured {dbex.Message}");
    //        }
    //        finally
    //        {
    //            conn.Close();
    //            Console.WriteLine("Connection Closed");
    //        }
    //    }
    //    static void Select()
    //    {
    //        //mengkoneksikan ke database
    //        SqlConnection conn = null; //deklarasi connecsi ADO
    //        try
    //        {

    //            conn = new SqlConnection(@"Server=RHNRAFIF\SQLEXPRESS;Database=ShipDB;Trusted_Connection=True;");

    //            //Buat SQL Command membuat tabel
    //            SqlCommand cmd = new SqlCommand(@"SELECT * FROM Student", conn);

    //            conn.Open(); //membuka koneksi ke database
    //            SqlDataReader sqlreader = cmd.ExecuteReader(); //menjalankan query select

    //            //melakukan looping, krn data berbetuk list
    //            while (sqlreader.Read())
    //            {
    //                Console.WriteLine(sqlreader["StudentId"] + ". " + sqlreader["Name"]);
    //            }


    //            Console.WriteLine("Connect and Insert Record Succesfully");
    //        }
    //        catch (DbException dbex)
    //        {
    //            Console.WriteLine($"Error Accured {dbex.Message}");
    //        }
    //        finally
    //        {
    //            conn.Close();
    //            Console.WriteLine("Connection Closed");
    //        }
    //    }
    //    static void Update()
    //    {
    //        //mengkoneksikan ke database
    //        SqlConnection conn = null; //deklarasi connecsi ADO
    //        try
    //        {

    //            conn = new SqlConnection(@"Server=RHNRAFIF\SQLEXPRESS;Database=ShipDB;Trusted_Connection=True;");

    //            //Buat SQL Command membuat tabel
    //            SqlCommand cmd = new SqlCommand(@"UPDATE Student SET Name = 'Rahma' WHERE StudentId = 2", conn);

    //            conn.Open(); //membuka koneksi ke database
    //            cmd.ExecuteNonQuery();


    //            Console.WriteLine("Connect and Update Record Succesfully");
    //        }
    //        catch (DbException dbex)
    //        {
    //            Console.WriteLine($"Error Accured {dbex.Message}");
    //        }
    //        finally
    //        {
    //            conn.Close();
    //            Console.WriteLine("Connection Closed");
    //        }
    //    }
    //    static void DatSetTabel()
    //    {
    //        SqlConnection conn = null; //deklarasi connecsi ADO
    //        try { 
    //        conn = new SqlConnection(@"Server=RHNRAFIF\SQLEXPRESS;Database=ShipDB;Trusted_Connection=True;");

    //        //Buat SQL Adapter
    //        SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Student", conn);

    //        //Memakai data tabel -- hanya bisa terisi oleh satu tabel saja
    //        DataTable data1 = new DataTable();
    //        sqlData.Fill(data1);

    //        Console.WriteLine("Menggunakan data Tabel");
    //        foreach (DataRow row1 in data1.Rows)
    //        {
    //            Console.WriteLine(row1["Name"] + " - " + row1["StudentId"]);
    //        }



    //        //Memakai Dataset -- dataset bisa untuk multitabel
    //        DataSet data = new DataSet();
    //        sqlData.Fill(data); //mengcopy isi ke data

    //        //melakukan looping, krn data masih berupa entity
    //        Console.WriteLine("Menggunakan data set");
    //        foreach (DataRow row in data.Tables[0].Rows)
    //        {
    //            Console.WriteLine(row["Name"] + " - " + row["StudentId"]);
    //        }

    //        Console.WriteLine("Connect and Update Record Succesfully");
    //    }
    //        catch (DbException dbex)
    //        {
    //            Console.WriteLine($"Error Accured {dbex.Message}");
    //        }
    //        finally
    //{
    //    conn.Close();
    //    Console.WriteLine("Connection Closed");
    //}
    //    }
    //    static void DataSetMultiTabel()
    //    {
    //        //DATASET adalah suatu obejek yang terdiri dari copy data yang minta ke SQL Server via SQL Statement
    //        //mengkoneksikan ke database
    //        SqlConnection conn = null; //deklarasi connecsi ADO
    //        try
    //        {

    //            conn = new SqlConnection(@"Server=RHNRAFIF\SQLEXPRESS;Database=ShipDB;Trusted_Connection=True;");

    //            //Buat SQL Adapter
    //            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM Student; SELECT * FROM Company", conn);

    //            //mapping
    //            sqlData.TableMappings.Add("Table", "Student");
    //            sqlData.TableMappings.Add("Table1", "Company");

    //            //add ke dataset
    //            DataSet data1 = new DataSet();
    //            sqlData.Fill(data1);

    //            Console.WriteLine("Menggunakan data Tabel Student");
    //            foreach (DataRow row1 in data1.Tables[0].Rows)
    //            {
    //                Console.WriteLine(row1["StudentId"] + " - " + row1["Name"]);
    //            }

    //            Console.WriteLine("Menggunakan data Tabel Company");
    //            foreach (DataRow row2 in data1.Tables[1].Rows)
    //            {
    //                Console.WriteLine(row2["CompanyId"] + " - " + row2["CompanyName"]);
    //            }


    //        }
    //        catch (DbException dbex)
    //        {
    //            Console.WriteLine($"Error Accured {dbex.Message}");
    //        }
    //        finally
    //        {
    //            conn.Close();
    //            Console.WriteLine("Connection Closed");
    //        }
    //    }
    //    static void DataSetCara2()
    //    {
    //        //DATASET adalah suatu obejek yang terdiri dari copy data yang minta ke SQL Server via SQL Statement
    //        //mengkoneksikan ke database
    //        SqlConnection conn = null; //deklarasi connecsi ADO
    //        try
    //        {
    //            //buka koneksi
    //            conn = new SqlConnection(@"Server=RHNRAFIF\SQLEXPRESS;Database=ShipDB;Trusted_Connection=True;");

    //            //Buat sql Command
    //            SqlCommand scm = new SqlCommand("SELECT * FROM Student; SELECT * FROM Company", conn);
    //            conn.Open();

    //            //melakukan data reader
    //            SqlDataReader sdr = scm.ExecuteReader();

    //            //inisial dataset
    //            DataSet dataSet = new DataSet();

    //            while (!sdr.IsClosed) //proses looping masing2 tabel
    //            {
    //                DataTable tab = new DataTable();
    //                tab.Load(sdr);
    //                dataSet.Tables.Add(tab);
    //            }

    //            //menampilkan hasil dengan loop
    //            Console.WriteLine("Menggunakan data Tabel Student");
    //            foreach (DataRow row1 in dataSet.Tables[0].Rows)
    //            {
    //                Console.WriteLine(row1["StudentId"] + " - " + row1["Name"]);
    //            }

    //            Console.WriteLine("Menggunakan data Tabel Company");
    //            foreach (DataRow row2 in dataSet.Tables[1].Rows)
    //            {
    //                Console.WriteLine(row2["CompanyId"] + " - " + row2["CompanyName"]);
    //            }


    //        }
    //        catch (DbException dbex)
    //        {
    //            Console.WriteLine($"Error Accured {dbex.Message}");
    //        }
    //        finally
    //        {
    //            conn.Close();
    //            Console.WriteLine("Connection Closed");
    //        }
    //    }
    //    static void readXML()
    //    {
    //        DataSet dataSet = new DataSet();
    //        DataTable dt = new DataTable("TableXML");
    //        dt.Columns.Add("col1", typeof(string));
    //        dataSet.Tables.Add(dt);

    //        string xmlData = "<XmlDS>" +
    //                             "<TableXML>" +
    //                                "<col1> value1 </col1>" +
    //                             "</TableXML>" +
    //                             "<TableXML>" +
    //                                "<col1> value2 </col1>" +
    //                             "</TableXML>" +
    //                          "</XmlDS>";

    //        StringReader xmlRead = new StringReader(xmlData);
    //        dataSet.ReadXml(xmlRead, XmlReadMode.IgnoreSchema);

    //        foreach (DataRow row in dataSet.Tables[0].Rows)
    //        {
    //            Console.WriteLine(row[0]);
    //        }
    //    }
}