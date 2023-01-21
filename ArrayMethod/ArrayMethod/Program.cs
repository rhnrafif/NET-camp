using System;
using System.Collections.Immutable;

namespace arrMethod
{
    class Program
    {
        static void Main()
        {


            //array adalah sekumpulan variabel sejenis


            //deklarasi array
            //int[] arr = new int[2];
            //arr[0] = 5;
            //arr[1] = 5;

            //int[] arr2 = new int[2] { 1, 2 };
            //int[] arr3 = new int[10] { 1, 2, 3, 4, 5, 6 ,7, 8, 9,10 };

            //Console.WriteLine(arr[1]);

            //Console.WriteLine(arr2[0]);

            //untuk mencetak array, bisa melakukan perulangan

            //for(int i = 0; i < arr3.Length; i++)
            //{
            //    Console.WriteLine("Cetak array menggunakan for loop");
            //    Console.WriteLine(arr3[i]);
            //}

            //int j = 0;
            //while(j < arr3.Length)
            //{
            //    Console.WriteLine("Cetak array menggunakan While");
            //    Console.WriteLine(arr3[j]);
            //    j++;
            //}

            //int k = 0;
            //do
            //{
            //    Console.WriteLine(arr3[k]);
            //    k++;

            //} while (k < arr3.Length);


            //mengisi array dengan dinamis
            //int[] arr5 = new int[5];

            //for (int i = 0; i < arr5.Length; i++)
            //{
            //    Console.Write($"isikan Nilai Array index ke {i} : ");
            //    arr5[i] = Convert.ToInt32(Console.ReadLine());
            //} 

            //for (int j = 0; j < arr5.Length; j++)
            //{
            //    Console.WriteLine($"Nilai Arr ke {j} adalah {arr5[j]}");
            //}

            //reassign array ke array lain
            //using System.Collections.Immutable;

            //int[] number = new int[5];
            //number[0] = 1;
            //number[1] = 3;
            //number[2] = 7;

            //int[] number4 = new int[3];

            //number4 = number; //copy by reference atau memory

            //Array.Copy(number, number4, 3);

            //Console.WriteLine(number[0]);
            //Console.WriteLine(number4[2]);


            //Resize Array
            //int[] array1 = new int[5] { 1, 2, 3, 4, 5, };

            //Console.WriteLine($"Length Array sebelum di resize adalah {array1.Length}");
            //Console.ReadKey();
            //Array.Resize(ref array1, 10);
            //Console.WriteLine($"Length Array sesudah di resize adalah {array1.Length}");
            //Console.ReadKey();

            //immutabale Array
            //var imArr = ImmutableArray.Create<int>(new int[5] { 1, 2, 3, 4, 5 });
            //foreach (int item in imArr)
            //{
            //    Console.WriteLine($"Ini isi imutable Array {item}");
            //}



            //Array 2 dimensiii --- array yaang berisi array didalamnya.. 
            
            //deklarasi
            //var arrDua = new int[4][];

            //inisialisasi element cara 1
            /*
            arrDua[0] = new int[5] { 1, 2, 3, 4, 5 };
            arrDua[1] = new int[3] { 8, 9, 10 };
            arrDua[2] = new int[7] {12, 13, 14, 15 , 17, 16, 18};
            arrDua[3] = new int[2] { 14, 20 };
            */
            /*
            //akses index tertentu dalam array
            Console.WriteLine(arrDua[2][2]); // maka hasilnya 14
            Console.ReadKey();
            */

            //menampilkan array 2 dimensi // menggunakan for loop
            /*for (int i = 0; i < arrDua.Length; i++)
            {
                Console.WriteLine($"Element array ke [{i}]");
                for(int j = 0; j < arrDua[i].Length; j++)
                {
                    Console.Write(arrDua[i][j]);
                }
                Console.WriteLine();
            } */

            //menggunakan foreach loop
            /*
            foreach (int[] arr in arrDua)
            {
                Console.WriteLine("Ini array pertama");
                foreach(int number in arr)
                {
                    Console.WriteLine($"Number nya adalah : {number}");
                }
            }
            */

            //method adalah block code yang bisa dipakai lagi
            //dengan void tanpa parameter
            //dengan void & parameter
            // tanpa void & dengan paramter -- harus pakai return
            // tanpa void dan tanpa parameter -- harus pakai return
            //penamaan method harus PascalCase(sangat disarankan);
            static double Lingkaran(double ukuran)
            {
                double hasil = ukuran * 2;
                return hasil;
            }

            static void cetakNama()
            {
                Console.WriteLine("Itachi Uchia");
            }

            cetakNama(); //contoh pemanggilan method void; //langsung terpanggil
            double hasilLing = Lingkaran(1.5); // contoh pemanggilan method return yaitu dengan menampung pada variabel

            //Console.WriteLine(Lingkaran(1.7)); //bisa seperti ini
           
            static string Contoh(string nama, int umur)
            {
                string hasil = nama + Convert.ToString(umur);
                return hasil;
            }

        }
    }
}

