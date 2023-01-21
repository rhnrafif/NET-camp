using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Collection
    {
        public void Coll()
        {
            //Array betsifat statis artinya data (index) tdk bisa diubah.
            //collection : sekumpulan data / class yang belu,terdefinisikan
            //collection juga termasuk array. tetapi lebih dinamis
            //collection berdifat generic dan hanya berisi satu data type.

            List<int> dataInteger = new List<int>();
            dataInteger.Add(1);
            dataInteger.Add(2);
            dataInteger.Add(3);
            dataInteger.Add(4);
            dataInteger.Add(5);

            //utk mengakses juga menggunakan foreach
            foreach(var item in dataInteger)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            //Console.WriteLine(dataInteger[0]); //krn sama seperti array, bisa diakses dengan index

            //menyisipkan nilai dalam collection
            dataInteger.Insert(1, 18); //index 1 dengan nilai 18
            Console.WriteLine("Sesudah di tambah :");
            foreach(int item in dataInteger)
            {
                Console.WriteLine(item) ;
            }

            //menghapus
            dataInteger.Remove(18); //yg diinput adalah itemnya, bukan indexnya;
            Console.WriteLine("setelah di remove");
            foreach (int item in dataInteger)
            {
                Console.WriteLine(item);
            }

            //menghapus dengan index
            dataInteger.RemoveAt(3); //yg dihpaus berdasarkan index ke 0

            //remove all
            dataInteger.RemoveAll(w => w > 1); //ini dinamakan lamda
            Console.WriteLine("setelah di remove All");
            foreach (int item in dataInteger) //hanya menampilkan nilai yang berisi 1
            {
                Console.WriteLine(item);
            }
            //mencari index dengan isi nilai 1
            int index = dataInteger.FindIndex(0, dataInteger.Count, num => num == 1);
            dataInteger[index] = 100;
            Console.WriteLine("Sekarang isinya adalah 100");
            foreach (int item in dataInteger) //hanya menampilkan nilai yang berisi 1
            {
                Console.WriteLine(item);
            }
        }
    }

    class CollStudent
    {
        public void CollStu()
        {
            //assign class dalam list
            List<Student> listStudent = new List<Student>();
            //jika mau assign, harus buat objectnya dlu
            Student listStu = new Student();
            listStu.Name = "Rafif";
            listStu.Id = 14;

            listStudent.Add(listStu);
            foreach (var item in listStudent)
            {
                Console.WriteLine($"Nama siswa adalah : {item.Name} dan Id nya : {item.Id}");
            }

            ////merubah isi dari coll menggunakan index
            int index = listStudent.FindIndex(0, listStudent.Count, x => x.Name == "Rafif"); //(mulai, berakhir, predicate)
            listStudent[index].Name = "Raihanudin Rafif";
            Console.WriteLine("Setelah di rubah menggunakan Index : ");
            foreach (var item in listStudent)
            {
                Console.WriteLine($"Nama siswa adalah : {item.Name} dan Id nya : {item.Id}");

            }
        }

    }
    //class utk dijadikan isi dalam collections
    class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
