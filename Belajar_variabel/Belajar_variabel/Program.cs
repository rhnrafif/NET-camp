using System;
namespace Belajarvariabel
{
    class Program
    {
        static void Main()
        {
            string a; //default value : null
            int luas; //default value : 0

            //value type, yakni variabel yang bertipe nilai
            //num, int, bool
            //reference type, yakni variabel yang berbentuk referensi atau string
            //string

            a = "Rafif";
            luas = 46;

            Console.Clear();

            //console readline digunakan untuk menginput

            Console.WriteLine("Tuliskan nama dan sekolah");
            Console.Write("Nama : ");
            string nama =  Console.ReadLine();
            Console.Write("Sekolah : ");
            string sekolah = Console.ReadLine();

            Console.WriteLine("Hasilnya : ...");

            Console.WriteLine("Nama : " + nama);
            Console.WriteLine("Sekolah : " + sekolah);


            //tipe data dinataranya :
            /*
             Reference, Penunjuk, Value
             
             
             */
            




        }
    }
}

