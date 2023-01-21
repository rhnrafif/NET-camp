using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Interface
    {
    }

    //interface adalah class yg belum di implementasi. biasanya digunakan untuk deklarasi sebuah operasi atau method object
    //perbedaan class, abstact, interface
    //Class, hanya memiliki non abstarct method, atau abstarct yang memiliki body saja.
    //Abstract, bisa memiliki non abstract atau abstarct method
    //Interface, Hanya memiliki abstarct method
    //abstarct bisa membuat constructor dan destructor, sedangkan interface tidak bisa keduanya.
    
    class CaraPanggil
    {
        static void Panggil()
        {
            //cara satu
            Kalkulator kalkulator = new Kalkulator(); //ini yg di instance adalah class Kalkulator
            var hasil = kalkulator.Add(7, 5);

            Console.WriteLine(hasil);

            //cara kedua
            IKalkulator kalkulatorObj = new Kalkulator(); //ini yg di instance adalah interface
            var hasil2 = kalkulatorObj.Substract(4, 3);

            //cara ketiga
            int resulSubtract = ((IKalkulator)kalkulatorObj).Substract(2, 4);
            Console.WriteLine(resulSubtract);
        }
    }
    
    interface ICollege //deklarasi pakai I di depan
    {
        public void student(); //ini contoh abstarct method. yaitu method kosng, tidak memiliki isi atau body
        public void Siswa();
    }

    interface ICollege2
    {
        public void student();
        public void Siswa();

    }
    class Sekolah : ICollege
    {
        public void Siswa()
        {
            throw new NotImplementedException();
        }

        public void student()
        {
            throw new NotImplementedException();
        }
    }

    //implementasi 2 interface dalam 1 class
    class Pendidikan2 : ICollege, ICollege2
    {
        public void Siswa()
        {
            throw new NotImplementedException();
        }

        public void student()
        {
            throw new NotImplementedException();
        }
    }
    class Pendidikan : ICollege, ICollege2 // 2 interface dalam satu class
    {
        //dibawah ini hanya penampung data Interface,
        //data didalamnya milik interface, bukan class Pendidikan
        void ICollege2.Siswa()
        {
            throw new NotImplementedException();
        }

        void ICollege2.student()
        {
            throw new NotImplementedException();
        }
        void ICollege.Siswa()
        {
            throw new NotImplementedException();
        }

        void ICollege.student()
        {
            throw new NotImplementedException();
        }
    }


    //perbedaan abstarct dengan interface

    interface IKalkulator // abstarct class, yakni tdk memiliki body method.
    {
        public int Add(int a, int b);
        public int Substract(int a, int b);
        public int Multiply(int a, int b);
        public int Devide(int a, int b);

    }

    class Kalkulator : IKalkulator //implementasi 1 interface dalam satu class
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Devide(int a, int b)
        {
            return a / b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Substract(int a, int b)
        {
            return a - b;
        }
    }
}
