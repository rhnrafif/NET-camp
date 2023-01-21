using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Test1
    {
        public void Test()
        {
            List<Animal> animal = new List<Animal>();
            Cat cat = new Cat(1,3, Makanan.Karnivora);
            cat.cat(2, 4, Makanan.Herbivora);
            animal.Add(cat);

            foreach(var item in animal)
            {
                Console.WriteLine(item);
            }

            Dog dog = new Dog
            {
                Kaki = 1,
                Mata = 3,
                Makanan = Makanan.Omnivora
            };
            animal.Add(dog);

            foreach (var item in animal)
            {
                Console.WriteLine(item);
            }
        }

    }
    
     abstract class Animal
    {
        public int Mata { get; set; }
        public int Kaki { get; set; }

        public Makanan Makanan { get; set; }

        //constructor
        protected Animal()
        {

        }

        //contsructor 2
        protected Animal(int mata, int kaki, Makanan makanan)
        {
            this.Mata = mata;
            this.Kaki = kaki;
            this.Makanan = makanan;
        }
    }
    class Cat : Animal
    {
        //jika const menggunakan param, maka memakai param
        public Cat(int mata, int kaki, Makanan makanan) : base (mata, kaki, makanan)
        {

        }
        public void cat(int mata, int kaki, Makanan makanan)
        {
            Console.WriteLine($"Halo ini Kucing punya {Mata} Mata, {Kaki} Kaki, Makan");
        }
    }

    class Dog : Animal
    {
        
    }

    public enum Makanan
    {
        Karnivora,
        Herbivora,
        Omnivora,
    }
}
