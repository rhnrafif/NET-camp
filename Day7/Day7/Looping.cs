using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Loop
    {
        //loop dalam collection
        //for, while, do while
        public void LoopColl()
        {
            List<int> list = new List<int>();

            int size = 10;

            list = Enumerable.Range(1, size).Select(i => i).ToList(); //LINQ <----

            //forloop biasa
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            //LINQ foreach
            Console.WriteLine("LINQ ForEach");
            list.ForEach(i =>
            {
                Console.WriteLine(i);
            });

            //Mempercepat Proses Loop

            //Paralel Foreach
            Console.WriteLine("Paralel ForEach");
            Parallel.ForEach(list, i => //THREADING --> yaitu membagi menjadi bebrepa bagian sehingga lebih cepat
            {
                Console.WriteLine(i);
            });

            //Paralel LINQ
            Console.WriteLine("Paralel LINQ");
            list.AsParallel().ForAll(i =>
            {
                Console.WriteLine(i);
            });
        }
    }
    class Student2 //ini class model, yaitu class yg tdk memiliki method
    {
        public int School { get; set; }
    }
}
