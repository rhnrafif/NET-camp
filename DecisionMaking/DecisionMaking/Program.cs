using System;
namespace DecisonMaking
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Tuliskan Nilai A :");
            //int A = Convert.ToInt32(Console.ReadLine());

            //if (A > 10)
            //    Console.WriteLine("Nilai A lebih besar dari 10");


            //if (A == 10)
            //{
            //    Console.WriteLine("Ini Berhasill");
            //    Console.WriteLine("Ini juga berhasil");
            //    return;
            //}
            //else
            //{
            //    Console.WriteLine("Nilai bukan 10 !");
            //}

            //Console.WriteLine("Ini diluar IF");

            //if (A == 10)
            //{
            //    Console.WriteLine("Nilai A sama dengan 10");
            //}
            //else if (A == 15)
            //{
            //    Console.WriteLine("Nilai A sama dengan 15");
            //}
            //else
            //{
            //    Console.WriteLine($"Nilai A adalah {A}");
            //}

            //nested if

            //if (A == 10)
            //{
            //    if (A < 12)
            //    {
            //        Console.WriteLine("Nilai A lebih kecil dari 12");
            //    }else if(A < 10){
            //        Console.WriteLine("Ini Tidak dijalankan !");
            //    }
            //}else if (A == 30)
            //{
            //    Console.WriteLine("Nilai A adalah 30");
            //}else if (A > 30)
            //{
            //    if(A > 25)
            //    {
            //        Console.WriteLine("Nilai lebih besar dari 25");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"Nilai A sebenarnya adalah {A}");
            //}


            //Console.WriteLine("Tuliskan Bulan : ");
            //int bulan = Convert.ToInt32(Console.ReadLine());
            //if ( bulan == 1)
            //{
            //    Console.WriteLine("Ini Bulan Januari");
            //}else if (bulan == 2)
            //{
            //    Console.WriteLine("Ini Bulan Februari");
            //}else if (bulan == 3)
            //{
            //    Console.WriteLine("Ini Bulan Maret");
            //}else if (bulan == 4)
            //{
            //    Console.WriteLine("Ini Bulan April");
            //}else if (bulan == 5)
            //{
            //    Console.WriteLine("Ini Bulan Mei");
            //}else if (bulan == 6)
            //{
            //    Console.WriteLine("Ini Bulan Juni");
            //}else if (bulan == 7)
            //{
            //    Console.WriteLine("Ini Bulan Juli");
            //}else if (bulan == 8)
            //{
            //    Console.WriteLine("Ini Bulan Agustus");
            //}else if (bulan == 9)
            //{
            //    Console.WriteLine("Ini Bulan September");
            //}else if (bulan == 10)
            //{
            //    Console.WriteLine("Ini Bulan Oktober");
            //}else if (bulan == 11)
            //{
            //    Console.WriteLine("Ini Bulan November");
            //}else if (bulan == 12)
            //{
            //    Console.WriteLine("Ini Bulan Desember");
            //}
            //else
            //{
            //    Console.WriteLine("Salah input bulan");
            //}
            //Console.WriteLine("-----------------------------");
            //Console.WriteLine("Aplikasi Selesai");

            //DECISION MAKING with LOGICAL OPERATOR 

            //Console.WriteLine("Tuliskan rpm : ");
            //int rPm = Convert.ToInt32(Console.ReadLine());

            //if ((rPm == 0) && (rPm > 3000))
            //{
            //    Console.WriteLine("Everything is Okay, the Engine is running along nicely ");
            //}else if (!(rPm < 10000))
            //{
            //    Console.WriteLine("The Engine is too dangerous  !");
            //}else
            //{
            //    Console.WriteLine("The Engine must tune up !");
            //}


            //SWITCH CASE
            //var nama = 4.0; //data tipe double

            //switch (nama)
            //{
            //    case 3.10 :
            //        Console.WriteLine("Nama nya Rafif");
            //        break;
            //    case 4:
            //        Console.WriteLine("Namanya rafif");
            //        break;
            //    case 5:
            //        Console.WriteLine("Namanya rAFIF");
            //        break;
            //    default:
            //        Console.WriteLine("Namanya tidak ada !");
            //        break;
            //}

            //string pr = "C#";
            //switch (pr)
            //{
            //    case "Java":
            //        Console.WriteLine("Ini Contoh");
            //        break;
            //    case "C#": //ini sama logikaknya dengan OR , ||
            //    case "C++":
            //        Console.WriteLine("Ini bahasa Pemrograman");
            //        break;
            //    case "Pyton":
            //    case "JS":
            //        Console.WriteLine("Ini Bhasa juga");
            //        break;
            //}

            //why not IF but switch

            //if ((pr.Equals("Java")))
            //{
            //    Console.WriteLine("Ini Contoh");
            //}else if((pr.Equals("C#")) || (pr.Equals("C++")))
            //{
            //    Console.WriteLine("Ini bahasa Pemrograman");
            //}

            //NESTED SWITCH//
            //    string lang = "Java";
            //    switch (lang)
            //    {
            //        case "C#":
            //            Console.WriteLine("Bahasa C#");
            //            break;
            //        case "Java":
            //            Console.WriteLine("Pick your Color");
            //            char color = Convert.ToChar(Console.ReadLine());
            //            switch (Char.ToUpper(color))
            //            {
            //                case 'R':
            //                    Console.WriteLine("Youu choose RED");
            //                    break;
            //                case 'G':
            //                    Console.WriteLine("you choose GREEN");
            //                    break;
            //                default:
            //                    Console.WriteLine("You Choos wrong color !");
            //                    break;
            //            }
            //            break;
            //    }

            //switch with if
            //int x = 2;
            //switch (x)
            //{
            //    case 1:
            //        Console.WriteLine("Ini nomor 1");
            //        break;
            //    case 2:
            //        x += 5;
            //        if (x == 7)
            //        {
            //            Console.WriteLine("Kamu Benar");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Kamu Salah");
            //        }
            //        break;
            //    case 3:
            //        Console.WriteLine("Ini Nomor 3");
            //        break;
            //    default:
            //        break;

            //}


            //for loop -- yaitu counter loop
            //increment
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Clear();

            //decrement
            //for(int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Clear();


            //while & do while ---> yaitu conditional loop 
            //int x = 1;
            //while(x <= 5)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}
            //Console.Clear();

            ////do while ---> conditional loop // do while akan mengeksekusi statement 1 kali walau kodisi false;
            //int y = 1;
            //do
            //{
            //    Console.WriteLine(y);
            //    y++;
            //}while(y <= 5);

            //Console.Clear();

            //nested loop
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    for(int j = 0; j <10; j++)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}


            //for(int i =0; i < 10; i++) //break utk berhenti loop, continue untuk melanjutkan loop;
            //{
            //    Console.WriteLine($"Loop i : {i}");

            //    if(i == 5)
            //    {
            //        break;
            //    }
            //}

            //string nama = "Raihanudin Rafif";
            //string biodata = $"Nama saya adalah {nama}"; //string interpolation
            //string biodata2 = string.Format("Nama saya adalah {0}", nama);

            //Console.WriteLine(biodata2);


            //app data siswa for loop
            Console.WriteLine("Input Data Siswa");
            Console.WriteLine("----------------------");
            
            Console.Write("Jumlah Siswa : ");
            int jumlahSiswa = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= jumlahSiswa ; i++){
                char grade;

                Console.WriteLine("------- Input Data Siswa-------");

                Console.Write("Nama : ");
                string nama = Console.ReadLine();

                Console.Write("Kelas : ");
                string kelas = Console.ReadLine();

                Console.Write("Mata Pelajaran : ");
                string maPel = Console.ReadLine();

                Console.Write("Nilai : ");
                int nilai = Convert.ToInt32(Console.ReadLine());

                if ((nilai > 90) && (nilai <= 100))
                {
                    grade = 'A';
                }else if ((nilai > 70) && (nilai <= 90))
                {
                    grade = 'B';
                }
                else if ((nilai > 60) && (nilai <= 70))
                {
                    grade = 'C';
                }
                else if ((nilai > 50) && (nilai <= 60))
                {
                    grade = 'D';
                }
                else
                {
                    grade = 'E';
                }

                Console.WriteLine("-------Output Data Siswa-------");

                Console.WriteLine($"Nama : {nama} , kelas : {kelas} , Mata Pelajaran : {maPel}, Nilai : {grade}");

                Console.WriteLine("-------End Record -------");

            }

        }


    }
}