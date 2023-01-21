//Ado .NET digunakan untuk mengakses SQL SErver dan RDBS Lain, biasanya digunakan oleh aplikasi Desktop, Umumnya .Net dibawah 4.3

//Dapper adalah object Mapping. Dapper menggunakan engine Ado .Net.
//Perbedaannya proses pengiriman berupa object dan hasilnya juga berupa object.


using Dapper;
using DapperEnigmaCamp;
using DapperEnigmaCamp.Aplications.Employees;
using DapperEnigmaCamp.Views.Employees;
using System.Data.SqlClient;

//Dalam Dapper ada perintah Execute dan Query,
//Exeecute yang tidak mengembalikan nilai,
//Query yang akan mengembalikan nilai, seperti select.
class Program
{
    //private static string connectionString = @"Server=RHNRAFIF\SQLEXPRESS;Database=ShipDB;Trusted_Connection=True;";
    static void Main()
    {
        
        Menu menu = new Menu();
        bool showMainMenu = true;
        while (showMainMenu)
        {
            Console.Clear();
            Console.WriteLine("Choose an Option");
            Console.WriteLine("1. Employee Menu");
            Console.WriteLine("2. Company Menu");
            Console.WriteLine("3. Department Menu");
            Console.WriteLine("4. Division Menu");
            Console.WriteLine("5. Exit");
            Console.Write("Select Option : ");

            switch (Console.ReadLine())
            {
                case "1":
                    menu.EmployeeMenu();
                    showMainMenu = true;
                    break;
                case "2":
                    //view
                    menu.CompanyMenu();
                    showMainMenu = true;
                    break;
                case "3":
                    //view
                    showMainMenu = true;
                    break;
                case "4":
                    //view
                    showMainMenu = true;
                    break;
                case "5":
                    showMainMenu = false;
                    break;
            }

        }

    }

    static void Scalars()
    {
        string connectionString = @"Server=RHNRAFIF\SQLEXPRESS;Database=ShipDB;Trusted_Connection=True;";
        //cara execute sacalar (count dll.)
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var countEmoployee = connection.ExecuteScalar("SELECT COUNT (*) FROM Employee");
            Console.WriteLine($"Total Employee adalah {countEmoployee}");
        }


        return;
    }
   
//    public class Student
//    {
//        public int StudentId { get; set; }
//        public string Name { get; set; }   
//    }

//    static void Notes()
//    {
//        //SIMPLE INSERT With Dapper

//        //var student = new Student();
//        //student.StudentId = 10;
//        //student.Name = "Madara";

//        //using (var connection = new SqlConnection(connectionString))
//        //{
//        //    connection.Open();
//        //Untuk delete dan Upadate sama saja, asal disesuaikan querynya
//        //    connection.Execute("INSERT INTO Student (StudentId, Name) VALUES (@StudentId, @Name)",
//        //        new { StudentId = student.StudentId, Name = student.Name });
//        //    connection.Close();
//        //}

//        //List<Student> students = new List<Student>();
//        //using (var connection = new SqlConnection(connectionString))
//        //{
//        //    var studentt = new Student();
//        //    studentt.StudentId = 1;
//        //    connection.Open();
//        //    //diubah ke list, krn return dari Query adalah berupa enum.
//        //    students = connection.Query<Student>("SELECT Name, StudentId FROM Student WHERE StudentId = @StudentId ",
//        //        new { StudentId = studentt.StudentId }).ToList();

//        //    var stu = students.FirstOrDefault(); //untuk mengambil value pertama dalam list //
//        //    //Console.WriteLine(stu.Name);
//        //    foreach (var student in students)
//        //    {
//        //        Console.WriteLine(student.Name + " - " + student.StudentId);
//        //    }

//        //    connection.Close();
//        //}
//    }
}