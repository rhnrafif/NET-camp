using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class StudentService : IStudentService
    {
        private List <DataSiswa> dataSiswa = new List <DataSiswa> (); //global variabel

        public DataSiswa(List<DataSiswa> dataSiswa)
        {
            this.dataSiswa = dataSiswa;
        }
        public void CreateSiswa()
        {
            DataSiswa dataSiswa = new DataSiswa(); //local variabel
            Console.Write("Tuliskan Nama");
            var nama = Console.ReadLine();
            Console.Write("Tuliskan Id");
            int id  = Convert.ToInt32(Console.ReadLine());

            dataSiswa.Name = nama;
            dataSiswa.Id = id;

        }

        public void DeleteSiswa()
        {
            throw new NotImplementedException();
        }

        public void GetAllSiswa()
        {
            foreach (var item in students)
            {
                Console.WriteLine($" {item.Name} yaitu {item.Id}");
            }
        }

        public void UpdateSiswa()
        {
            foreach (var item in dataSiswa)
            {
                Console.WriteLine($"{item.Name} DAN {item.Id}");
            }
        }
    }
}
