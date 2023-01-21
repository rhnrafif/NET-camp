using System.ComponentModel;

class Program
{
    static void Main()
    {
        //panggil menu
        Menus();

    }

    
    static void Menus()
    {
        CutBamboo cutBamboo = new CutBamboo();
        MinusValue minusValue = new MinusValue();
        Minimax miniMax = new Minimax();

        Console.WriteLine("Berikut Daftar Aplikasi :");
        Console.WriteLine();
        Console.WriteLine("1. Cut The Bamboo");
        Console.WriteLine("2. Mencari Nilai Minimal dan Maximal ");
        Console.WriteLine("3. Mencari Angka Minus Terbesar ");
        Console.WriteLine("4. Menutup Aplikasi ");
        Console.WriteLine();
        Console.Write("Pilih Menu ke : ");
        int input = Convert.ToInt32(Console.ReadLine());

        switch (input)
        {
            case 1:

                Console.WriteLine("Pilih Aplikasi Cut the Bamboo");
                Console.WriteLine("1. Cut the Bamboo ");
                Console.WriteLine("2. Cut the Bamboo 2");
                Console.Write("Pilih : ");
                int input2 = Convert.ToInt32(Console.ReadLine());

                switch (input2)
                {
                    case 1:
                        cutBamboo.CutTheBamboo();
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Aplikasi Selesai");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Main();
                        break;
                    case 2:
                        cutBamboo.CutTheBamboo2();
                        Console.WriteLine();
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Aplikasi Selesai");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine();
                        Main();
                        break;
                }

                break;
            case 2:
                Console.WriteLine("Aplikasi Mencari Nilai Minimal dan Maximal");
                Console.WriteLine();
                miniMax.MiniMax();
                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Aplikasi Selesai");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
                Main();
                break;
            case 3:
                Console.WriteLine("Aplikasi Mencari Minus Terbesar");
                Console.WriteLine();
                minusValue.Minus();
                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Aplikasi Selesai");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine();
                Main();
                break;
            case 4:
                Console.WriteLine("Aplikasi akan berhenti.");
                Console.WriteLine("Tekan tombol manapun untuk menutup console");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine();
                Console.WriteLine("Menu tidak ada, Mohon inputkan lagi");
                Console.WriteLine("-----------------------------------");
                Main();
                break;
        }
    }
    /*
    static void Minus()
    {
        Console.WriteLine("Tekan apasaja untuk memulai");
        Console.WriteLine();
        Console.WriteLine("new int[] { 4, 3, 2, 1, -1, -3, -4 };");
        Console.ReadKey();
        Console.WriteLine();
        int[] arr2 = new int[] { 4, 3, 2, 1, -1, -3, -4 };

        int[] arre = new int[arr2.Length];
        for (int i = 0; i < arr2.Length; i++)
        {
            if (arr2[i] < 0)
            {

                int a = arr2[i] + 1;
                arre[0] = a;
                if (arre[0] != 0)
                {
                    if (arre[0] != arr2[i])
                    {
                        break;
                    }
                }

            }

        }
        Console.WriteLine($"Output : {arre[0]}");
    }

    static void MiniMax()
    {
        Console.Write("Berapa isi array yang akan di input ? : ");
        int init = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[init];

        for (int i = 1; i <= init; i++)
        {
            Console.Write($"tuliskan array ke {i} : ");
            int arIn = Convert.ToInt32(Console.ReadLine());
            arr[i - 1] = arIn;
        }
        var res = MinMax(arr);
        var res1 = $"Min : {arr[0]}";
        Console.WriteLine(res);
        Console.WriteLine(res1);

        
    }

    static string MinMax(int[] arr)
    {
        Array.Sort(arr);

        int a = arr.Length - 1;
        string max = $"Max : {arr[a]}";


        return max ;

    }

    static void CutTheBamboo()
    {
        Console.WriteLine("Tuliskan jumlah bambu dengan pemisan (,) koma ");
        Console.Write("bamboos : ");
        string input = Console.ReadLine();

        var bamboo = input.Split(",");

        Console.Write("Cuts : ");
        int cut = Convert.ToInt32(Console.ReadLine());

        int[] bambu = Array.ConvertAll(bamboo, i => int.Parse(i));

        //Console.WriteLine(cut);
        Console.WriteLine("initial :");
        for (int i = 0; i < bambu.Length; i++)
        {
            int a = bambu[i];
            string outP = "|";
            for (int j = 1; j <= a; j++)
            {
                outP += "-";
            }
            Console.WriteLine(outP);
        }

        for (int k = 1; k <= cut; k++)
        {

            Console.WriteLine($"cycle cuts : {k} ");
            for (int l = 0; l < bambu.Length; l++)
            {
                int b = bambu[l] - k - 1;
                int outY = bambu[l] - k;


                string outC = "|";
                for (int j = 0; j <= b; j++)
                {
                    outC += "-";
                }
                Console.WriteLine(outC);

            }
        }
    }

    static void CutTheBamboo2()
    {
        Console.WriteLine("Tuliskan jumlah bambu dengan pemisan (,) koma ");
        Console.Write("bamboos : ");
        string input = Console.ReadLine();

        var bamboo = input.Split(",");

        Console.Write("Cuts : ");
        int cut = Convert.ToInt32(Console.ReadLine());

        int[] bambu = Array.ConvertAll(bamboo, i => int.Parse(i));

        //Console.WriteLine(cut);
        Console.WriteLine("initial :");
        for (int i = 0; i < bambu.Length; i++)
        {
            int a = bambu[i];
            string outP = "|";
            for (int j = 1; j <= a; j++)
            {
                outP += "-";
            }
            Console.WriteLine(outP);
        }

        for (int k = 1; k <= cut; k++)
        {
            

            Console.WriteLine($"cycle cuts : {k} ");
            for (int l = 0; l < bambu.Length; l++)
            {
                int b = bambu[l] - k - 1;
                int outY = bambu[l] - k;

                if(outY < 0 || b < 0)
                {

                    Console.WriteLine("| Bambu sudah habis :(");

                }
                else
                {
                    string outC = "|";
                    for (int j = 0; j <= b; j++)
                    {
                        outC += "-";
                    }
                    Console.WriteLine(outC);
                }

            }
        }
    }
    */
}

class Minimax
{
    public void MiniMax()
    {
        Console.Write("Berapa isi array yang akan di input ? : ");
        int init = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[init];

        for (int i = 1; i <= init; i++)
        {
            Console.Write($"tuliskan array ke {i} : ");
            int arIn = Convert.ToInt32(Console.ReadLine());
            arr[i - 1] = arIn;
        }
        var res = MinMax(arr);
        var res1 = $"Min : {arr[0]}";
        Console.WriteLine();
        Console.WriteLine("Output :");
        Console.WriteLine(res);
        Console.WriteLine(res1);


    }

    static string MinMax(int[] arr)
    {
        Array.Sort(arr);

        int a = arr.Length - 1;
        string max = $"Max : {arr[a]}";


        return max;

    }
}

class MinusValue
{
    public void Minus()
    {
        Console.WriteLine("Tekan apasaja untuk memulai");
        Console.WriteLine();
        Console.WriteLine("new int[] { 4, 3, 2, 1, -1, -3, -4 };");
        Console.ReadKey();
        Console.WriteLine();
        int[] arr2 = new int[] { 4, 3, 2, 1, -1, -3, -4 };

        int[] arre = new int[arr2.Length];
        for (int i = 0; i < arr2.Length; i++)
        {
            if (arr2[i] < 0)
            {

                int a = arr2[i] + 1;
                arre[0] = a;
                if (arre[0] != 0)
                {
                    if (arre[0] != arr2[i])
                    {
                        break;
                    }
                }

            }

        }
        
        Console.WriteLine($"Output : {arre[0]}");
    }
}

class CutBamboo
{
    public void CutTheBamboo()
    {
        Console.WriteLine("Tuliskan jumlah bambu dengan pemisan (,) koma ");
        Console.Write("bamboos : ");
        string input = Console.ReadLine();

        var bamboo = input.Split(",");

        Console.Write("Cuts : ");
        int cut = Convert.ToInt32(Console.ReadLine());

        int[] bambu = Array.ConvertAll(bamboo, i => int.Parse(i));

        //Console.WriteLine(cut);
        Console.WriteLine("initial :");
        for (int i = 0; i < bambu.Length; i++)
        {
            int a = bambu[i];
            string outP = "|";
            for (int j = 1; j <= a; j++)
            {
                outP += "-";
            }
            Console.WriteLine(outP);
        }

        for (int k = 1; k <= cut; k++)
        {

            Console.WriteLine($"cycle cuts : {k} ");
            for (int l = 0; l < bambu.Length; l++)
            {
                int b = bambu[l] - k - 1;
                int outY = bambu[l] - k;


                string outC = "|";
                for (int j = 0; j <= b; j++)
                {
                    outC += "-";
                }
                Console.WriteLine(outC);

            }
        }
    }

    public void CutTheBamboo2()
    {
        Console.WriteLine("Tuliskan jumlah bambu dengan pemisan (,) koma ");
        Console.Write("bamboos : ");
        string input = Console.ReadLine();

        var bamboo = input.Split(",");

        Console.Write("Cuts : ");
        int cut = Convert.ToInt32(Console.ReadLine());

        int[] bambu = Array.ConvertAll(bamboo, i => int.Parse(i));

        //Console.WriteLine(cut);
        Console.WriteLine("initial :");
        for (int i = 0; i < bambu.Length; i++)
        {
            int a = bambu[i];
            string outP = "|";
            for (int j = 1; j <= a; j++)
            {
                outP += "-";
            }
            Console.WriteLine(outP);
        }

        for (int k = 1; k <= cut; k++)
        {


            Console.WriteLine($"cycle cuts : {k} ");
            for (int l = 0; l < bambu.Length; l++)
            {
                int b = bambu[l] - k - 1;
                int outY = bambu[l] - k;

                if (outY < 0 || b < 0)
                {

                    Console.WriteLine("| Bambu sudah habis :(");

                }
                else
                {
                    string outC = "|";
                    for (int j = 0; j <= b; j++)
                    {
                        outC += "-";
                    }
                    Console.WriteLine(outC);
                }

            }
        }
    }
}
