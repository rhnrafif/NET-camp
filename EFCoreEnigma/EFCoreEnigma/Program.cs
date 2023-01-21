using EFCoreEnigma.Cores;
using EFCoreEnigma.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Data.Common;

//class Program
//{
//    static void Main()
//    {
//        //buat object dlu dr model
//        var student = new Student();
//        student.StudentCode = "SIS-003";
//        student.StudentName = "Hyuga Neji";

//        //membuat context dr school context
//        var context = new SchoolContext();
//        context.Students.Add(student); //Menambah Record Baru
//        context.SaveChanges(); //simpan perubahan

//        Console.WriteLine("Sukes Menambah Record Student !");


//    }
//}

/* Step configurasi menggunakan EFCore
 * 1. Membuat Model Tabel dan schema nya
 * 2. Membuat Context yang menurunkan DbContext. 
 * isi dr context ini adalah configurasi database dan tabel, 
 * lalu memuat context DbSet yg merepresntasikan model 
 * dan set get udh menampung input ke context
 * 
 * 3. Migrasi database dengan perintah 'Add-Migration (nama migrasi)'
 * 4. Update Databse dengan perintah 'Update-Database'
 * 5. Database siap digunakan
 
 */

/* Cara Membuat Relational One To many Database di C#
 1. Membuat Model tabel terlebih dahulu, satu main tabel, satu tabel 
 2. Implementasikan FK di salahsatu tabel (bukan yg main tabel) di model tabel tersebut
 3. Buat ICollection sebagai penghubung
 
 */

/* Cara Membuat Relational Many To many Database di C#
 1. M
 
 */


//class Program
//{
//    static void Main()
//    {
//        var student = new Student();
//        student.StudentId = 1;
//        student.StudentCode = "SHI-001";
//        student.StudentName = "Madara Uchihha Hashirama";

//        var context = new SchoolContext();
//        //context.Update(student); //cara simple
//        //context.Students.Update(student); //cara 1
//        context.Update<Student>(student); //cara 2
//        context.SaveChanges();
//        Console.WriteLine("Sukse Mengupdate Data Madara");


//    }
//}

//class Program
//{
//    static void Main()
//    {
//        //var context = new SchoolContext();
//        //var student = context.Students.FirstOrDefault(w => w.StudentId == 2);//get data dulu

//        //context.Remove(student); //perintah untuk DELETE
//        //context.SaveChanges();
//        //Console.WriteLine("Sukses Menghapus Data ");

//        //jika menggunakan transaction

//        var contextTrans = new SchoolContext();
//        var studentTrans = contextTrans.Students.FirstOrDefault(w => w.StudentId == 3);
//        try
//        {
//            contextTrans.Database.BeginTransaction();
//            contextTrans.Remove(studentTrans);
//            contextTrans.SaveChanges();
//            contextTrans.Database.CommitTransaction();

//            Console.WriteLine("Transaction Succes");
//        }
//        catch (DbException de)
//        {
//            Console.WriteLine(de.Message);
//            contextTrans.Database.RollbackTransaction();
//        }

//    }
//}


//class Program
//{
//    static void Main()
//    {
//        //cara get itu dengan context nya
//        var context = new SchoolContext();

//        var listStudents = context.Students.ToList(); //get semua data tabel student
//        var listStudent = context.Students.Where(w => w.StudentId == 1); //get id tertentu

//        foreach(Student student in listStudents)
//        {
//            Console.WriteLine($"{student.StudentCode} - {student.StudentName}");
//        }

//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var student = new Student();

//        student.StudentCode = "SHI-098";
//        student.StudentName = "Namikaze Minato";

//        var context = new SchoolContext();

//        add dengan cara 1 dan 2
//        context.Students.Add(student); //cara 1
//        context.Add<Student>(student); //cara 2
//        context.SaveChanges();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        //ada banyak cara untuk mendapatkan data dr database, bisa menggunakan
//        //List, FirstorDefault, Fist, FromSql, Where dll
//        var context = new SchoolContext();

//        //var student = context.Students.First();


//        var students = context.Students
//            .FromSql($"SELECT * FROM Students WHERE StudentId = '1'")
//            .FirstOrDefault();

//        Console.WriteLine($"{students.StudentCode} - {students.StudentName}");
//    }
//}

//class Program
//{
//    //ini CREATE VIEW nya sudah di eksekusi di SSMS
//    static void Main()
//    {
//        var context = new SchoolContext();
//        var viewStudentAddress = context.vw_StudentAddresses.ToList();

//        foreach (var itemStudent in viewStudentAddress)
//        {
//            Console.WriteLine($"{itemStudent.StudentId} - {itemStudent.StudentName} - {itemStudent.Address1} - {itemStudent.Address2}");
//        }
//    }
//}

//class Program
//{
//    //ini CREATE VIEW di EFCORE
//    static void Main()
//    {
//        //perintah untuk mengeksekusi perintah Native SQL, sample adalah dengan membuat view;
//        // Dengan Method ExecuteSqlRaw 
//        var context = new SchoolContext();
//        context.Database.ExecuteSqlRaw(@"CREATE VIEW View_Student AS 
//                                            SELECT StudentId, StudentName 
//                                        FROM Students");

//        //bisa cek di SSMS folder View

//    }
//}


//FromSQLRaw == untuk melakukan query yang mengembalikan nilai
//ExecuteSqlraw == untuk melakukan query yang tak mengembalikan nilai
//modelByuilder itu digunakan untuk aktivitas perubahan yang ada dalam suatu tabel, misalnya merubah tipe data pada field tabel
//bisa juga untuk create. insert sebuah data yang secara default dimasukan ketika deploy database
//class Program
//{
//    static void Main()
//    {
//        //perintah untuk mengeksekusi perintah Native SQL
//        var context = new SchoolContext();

//        //Select menggunakan From SQL Raw
//        var studentsResult = context.Students.FromSqlRaw(@"SELECT * FROM Students WHERE StudentId = {0}", 2).FirstOrDefault();

//        Console.WriteLine($"{studentsResult.StudentId}. {studentsResult.StudentName} - {studentsResult.Gender}");

//        //update menggunakan SQL Execute
//        //context.Database.ExecuteSqlRaw(@"UPDATE Students SET StudentName = 'Sasuke Uciha' WHERE StudentId = 2");

//        //var student = context.Students.FirstOrDefault(w => w.StudentId == 3);
//        //student.StudentName = "Madara Uchiha";
//        //student.Gender = 1;
//        //context.Update(student);
//        //context.SaveChanges();

//        //Console.WriteLine("Update Record Succesfully");

//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();
//        var student1 = new Student();

//        student1.StudentCode = "SHI-005";
//        student1.StudentName = "Kakuzu";
//        student1.DoB = DateTime.Now;
//        student1.Gender = Gender.male;

//        var student2 = new Student();
//        student2.StudentCode = "SHI-006";
//        student2.StudentName = "Konan";
//        student2.DoB = DateTime.Now;
//        student2.Gender = Gender.female;

//        var studentList = new List<Student>();
//        studentList.Add(student1);
//        studentList.Add(student2);

//        context.Students.AddRange(studentList); //save multi record
//        context.SaveChanges();

//        Console.WriteLine("Save Records Succesfully");

//    }
//}

class Program
{
    static void Main()
    {
        var context = new SchoolContext();
        var student = new Student();

        student.StudentName = "Regan";

        context.Students.Update(student);
        context.SaveChanges();

        Console.WriteLine("Save Records Succesfully");

    }
}