using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    //Hastable : kumpulan key/value yang diatur sedemikian rupa berdasarkan hash key
    //Key itu immutable
    //Key tidak boleh null

    //deklarasi
    class HashT
    {
        public void Hash()
        {
            //cara 1
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Nama1", "rafif");
            hashtable.Add("Nama2", "Rafif");
            hashtable.Add("Nama3", "RAFIF");

            Console.WriteLine("hash Table Cara 1");
            foreach(DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + "=" + item.Value);
            }

            //cara 2
            Hashtable hashtable1 = new Hashtable()
            {
                { 1, "hallo"},
                { 2, "saya" },
                { 3, 1000},
                { 4, null}
            };
            Console.WriteLine("hash Table Cara 2");
            foreach (DictionaryEntry item in hashtable1)
            {
                Console.WriteLine(item.Key + "=" + item.Value);
            }
            Console.Clear();

            //assign class ke hashtable
            Student student = new Student();
            student.Nisn = 0443340244;
            student.Nama = "rafif";

            Hashtable hashtable2 = new Hashtable();
            hashtable2.Add("stuDent", student);
            var hasil = hashtable2["stuDent"];
            var resultHash = (Student)hasil; //casting object
            Console.WriteLine(resultHash.Nama);
            Console.Clear();

            //cara remove hashtable adalah remove by key
            hashtable.Remove("Nama1");
            Console.WriteLine("Menghapus Hashtable dengan key ke 1");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + "=" + item.Value);
            }
            Console.Clear();


            //cek dengan nilai key
            bool isExist = hashtable.Contains("Nama2");
            Console.WriteLine(isExist);
            //cek dengan nilai value
            bool isContains = hashtable.ContainsValue("RAFIF");
            Console.WriteLine(isContains);
        }

        class Student
        {
            public int Nisn { get; set; }
            public string Nama { get; set; }
        }
    }
    
}
