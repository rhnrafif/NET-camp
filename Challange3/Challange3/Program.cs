using System;
namespace LuasSegitiga
{
    class Program
    {
        static void Main()
        {
            Console.Write("Inputkan Jari - Jari : ");
            decimal stdin = Convert.ToDecimal(Console.ReadLine());
            decimal jariJari = stdin * stdin;

            decimal phi = Convert.ToDecimal(3.14);
            

            decimal result = jariJari * phi;
            Console.Write($"Luas Lingkaran adalah : {result}");

        }
    }
}