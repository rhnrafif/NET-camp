//using System;
//namespace ResWord
//{
//    class Program
//    {
//        static void Main()
//        {
//            //reserve keyword --- kata key yang sudah digunakan oleh compiler csharp;
//            //pointer
//            /*
//            {
//                int a = 10;
//                int* ptr = &a;

//                Console.WriteLine($"Valu : {a}");
//                Console.WriteLine($"Valu : {(int)ptr}");

//            }
//            */

//            //operator



//        }
//    }
//}





//using System;
//namespace belajardatatipe 
//{ 
//    class Program
//    {
//        static void Main ()
//        {
//            string nama = "rafif";
//            int umur = 21;
//            string sekolah = "SMA";
//            char grade = 'A';
//            string contoh = "Ini Juga";
//            string contoh2 = " Ini contoh kedua";

//            Console.WriteLine($"Nama : {nama}");
//            Console.WriteLine($"umur: {umur}");
//            Console.WriteLine($"SEkolah : {sekolah}");
//            Console.WriteLine($"grade : {grade}");

//            //contoh console dua line atau lebih
//            Console.WriteLine($@"Nama saya : {contoh}
//                    Umur : {contoh2}
//");

//            Console.Clear();

//            //tipe data integer
//            Int16 num1 = 123; //int 16bit juga disebut short
//            Int32 num2 = 456; // nilai default integer
//            Int64 num3 = 789; // int 64bit juga disebut long

//            //tipe data double/float
//            double dob1 = 1.77;
//            decimal dec1 = 10.56m;

//            //menukar variabel
//            int a = 15;
//            int b = 20;

//            //balik nilai a menjadi b dan sebaliknya, 20 - 15

//            (a, b) = (b, a);

//            //string format
//            Console.WriteLine("{0} - {1}",a , b );


//        }
//    }

//}


//using System;
//namespace Operator
//{
//    class Program
//    {
//        static void Main()
//        {
//            int a = 10;
//            int b = 25;
//            int c = a + b;
//            int d = a - b;
//            int e = b / a;

//            Console.WriteLine($"Hasil Penambahan adalah : {c}");
//            Console.WriteLine($"Hasil Pengurangan adalah : {d}");
//            Console.WriteLine($"Hasil Perkalian adalah : {e}");
//            Console.ReadKey();

//            //task 1

//            int f = 10;
//            int g = 8;

//            f = f + g;
//            g = f - g;
//            f = f - g;

//            //division

//            //modulus == sisa pembagian


//        }
//    }
//}

//using System;
//namespace AssignOp
//{
//    class Program
//    {
//        static void Main()
//        {
//            int a = 10;
//            int b = 20;
//            int c = 35;
//            int d = 8;

//            a = a + b;
//            Console.WriteLine($"hasil a adalah  {a} ");

//            b -= b;
//            Console.WriteLine($"hasil b adalah {b}");

//            a %= a;
//            Console.WriteLine($"Hasil modulus a adalah {a}");

//            c = c / d;
//            Console.WriteLine($"ini hasilnya {c}");
//        }
//    }
//}

using System;
namespace OperatorRel
{
    class Program
    {
        static void Main()
        {
            //relation operator
            bool Result;
            int Num1 = 5, Num2 = 10;

            Result = (Num1 == Num2);
            Console.WriteLine($"Operator (==) menghasilkan value {Result}");

            Result = (Num1 < Num2);
            Console.WriteLine($"Operator (<) menghasilkan value {Result}");

            Result = (Num1 > Num2);
            Console.WriteLine($"Operator (>) menghasilkan value {Result}");

            Result = (Num1 <= Num2);
            Console.WriteLine($"Operator (<=) menghasilkan value {Result}");

            Result = (Num1 >= Num2);
            Console.WriteLine($"Operator (>=) menghasilkan value {Result}");

            Result = (Num1 != Num2);
            Console.WriteLine($"Operator (!=) menghasilkan value {Result}");

            Console.Clear();

            //logical operator 
            bool x = false, y = false, z; //inisialisasi variabel secara oneline.

            z = x && y;
            Console.WriteLine($"Hasil logical operator AND adalah {z}");

            z = x || y;
            Console.WriteLine($"Hasil logical operator OR adalah {z}");

            z = !y;
            Console.WriteLine($"Hasil logical operator NOT adalah {z}");

            Console.Clear();

            bool res1 = true;
            bool res2 = false;
            bool res3;

            Console.WriteLine(res1 && res2);


        }
    }
}