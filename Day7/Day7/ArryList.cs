using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    

    class ArryList
    {
        //sama seperti collection, tetapi Array list bisa berisi lebih dari satu tipe data object
        public void ArrList()
        {
            var siswa = new Siswa();
            siswa.Umur = 10;


            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add(2);
            arrList.Add(3);
            arrList.Add("Rafif"); //menrima string
            arrList.Add(true); //menerima boolean
            arrList.Add(siswa.Umur); //menrima value get dari class Siswa yg sudah diisi di line 18;

            Console.WriteLine("Isi Array List");
            foreach(var item in arrList)
            {
                Console.WriteLine(item);
            }

            //merubah isi array index tertentu
            arrList[0] = "KonohaGakure"; //dirubah secara index langsung
            Console.WriteLine("Setelah Isi Array ke 1 dirubah menjadi konoha");
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }

            //mrubah dengan cara index
            int ind = arrList.IndexOf("KonohaGakure"); //mencari index arrList yg berisi value Konohagkaure
            arrList[ind] = "Rafif lagi dong";
            Console.WriteLine("Setelah Isi Array KonohaGakure dirubah");
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Siswa
    {
        public int Umur { get; set; }
    }
}
