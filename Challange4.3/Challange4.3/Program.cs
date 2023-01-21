using System.Globalization;
using System.Runtime.ExceptionServices;

public class Program
{
    
    //public static void Main(String[] args)
    //{
    //    int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
    //    int[] anotherNumbers = new int[] { 4, 5, 6, 7, 8, 9, 10 };
    //    /* taruh code disini*/

    //    Console.WriteLine("Output dari Irisan Array tersebut adalah :");
    //    for(int i = 0; i < numbers.Length; i++)
    //    {
    //        for(int j = 0; j < anotherNumbers.Length; j++)
    //        {
    //            if (anotherNumbers[j] == numbers[i])
    //            {
    //                Console.WriteLine($" {anotherNumbers[j]} ");
    //            }

    //        }
    //    }

    //} 

    //static void Main()
    //{
    //    Console.Write("Inputkan angka : ");
    //    int scanner = Convert.ToInt32(Console.ReadLine());

    //    string bintang = "";
    //    Console.WriteLine("Perulangan Pertama untuk bintang ");
    //    for (int i = 1; i <= scanner; i++)
    //    {
    //        bintang += "*";
    //        Console.WriteLine(bintang);

    //    }
    //    Console.WriteLine("Perulangan Kedua untuk bintang ");
    //    for (int j = 1; j <= scanner; j++)
    //    {
            
    //        for (int k = scanner; k >= j; k--)
    //        {
    //            Console.Write("*");

    //        }
    //        Console.WriteLine();

    //    }


    //}
    
    //static void Main()
    //{
    //    int[] arr = new int[8] { 7, 20, 39, 2, 48, 520, 5, 5 };
    //    int result;

    //    for(int i = 0; i < arr.Length - 2; i++)
    //    {
    //        for(int j = 0; j < arr.Length - 2; j++)
    //        {
    //            if (arr[j] == arr[j + 1])
    //            {
    //                result = arr[j + 1];
    //                arr[j + 1] = arr[j];
    //                arr[j] = result;
    //            }
    //        }
    //    }
    //    foreach( var r in arr)
    //    {
    //        Console.WriteLine($" {r} ");
    //    }
    //    //Console.WriteLine(arr);
    //}

    //static void Main()
    //{
    //    Console.Write("Tuliskan Angka pertama : ");
    //    int angka1 = Convert.ToInt32(Console.ReadLine());

    //    Console.Write("Tuliskan Angka pertama : ");
    //    int angka2 = Convert.ToInt32(Console.ReadLine());

    //    var hasil = Multiply(angka1, angka2);
    //    Console.WriteLine(hasil);
    //}
    //static int Multiply(int a, int b)
    //{
    //    return a * b;
    //}
    /*
    static void Main()
    {
        Console.WriteLine("tuliskan kata : ");
        var masukan = Console.ReadLine();

        var r = masukan.ToArray();


        var res = HitungKata(r);
        
        Console.WriteLine("Kata Dalam kalimat tersebut berjumlah " + res);

  

    }

    static int HitungKata(char[] arr1)
    {
        var input = new String(arr1);
        int result;
        result = input.Split(' ').Length;

        return result;
    }
    */


}