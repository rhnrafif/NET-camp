using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    
    internal class ClassModel
    {
        private static List<DataSiswa> datasiswa = new List<DataSiswa>(); //global variabel
        public void ClassModels()
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            IStudentService studentService = new StudentService(datasiswa);
            Console.Clear();
            Console.WriteLine("Choose an option : ");
            Console.WriteLine("1) Add Student ");
            Console.WriteLine("2) Delete Student ");
            Console.WriteLine("3) Update Student ");
            Console.WriteLine("4) Get All Student ");
            Console.Write("\r\n Select Option");

            switch (Console.ReadLine()) //local variabel, harus disetor ke global agar bisa diakses ke method lain
            {
                case "1":
                    studentService.CreateSiswa();
                    return false;
                case "4":
                    studentService.GetAllSiswa();
                    return false;
                default:
                    return true;
            }
        }

        //private static void CreateStudent()
        //{
        //    Student student = new Student();
        //    student.Name = "rafif";
        //    student.Id = 12;

        //    students.Add(student);

        //    Console.WriteLine($"{student.Id} yaitu {student.Name}");
        //}

        //private static void GetStudent()
        //{

        //    foreach(var item in students)
        //    {
        //        Console.WriteLine($" {item.Name} yaitu {item.Id}");
        //    }

        //}
    }
}
