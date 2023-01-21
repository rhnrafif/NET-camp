Console.WriteLine("Tanggal : ");
int tanggal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bulan : ");
int bulan = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Tahun : ");
int tahun = Convert.ToInt32(Console.ReadLine());

if (tanggal <= 31 && tanggal >= 1 && bulan <= 12 && bulan >= 1 && tahun > 1000)
{
    switch (bulan)
    {
        case 1:
            Console.WriteLine($"{tanggal} Januari {tahun}");
            break;
        case 2:
            Console.WriteLine($"{tanggal} Februari {tahun}");
            break;
        case 3:
            Console.WriteLine($"{tanggal} Maret {tahun}");
            break;
        case 4:
            Console.WriteLine($"{tanggal} April {tahun}");
            break;
        case 5:
            Console.WriteLine($"{tanggal} Mei {tahun}");
            break;
        case 6:
            Console.WriteLine($"{tanggal} Juni {tahun}");
            break;
        case 7:
            Console.WriteLine($"{tanggal} Juli {tahun}");
            break;
        case 8:
            Console.WriteLine($"{tanggal} Agustus {tahun}");
            break;
        case 9:
            Console.WriteLine($"{tanggal} September {tahun}");
            break;
        case 10:
            Console.WriteLine($"{tanggal} Oktober {tahun}");
            break;
        case 11:
            Console.WriteLine($"{tanggal} November {tahun}");
            break;
        case 12:
            Console.WriteLine($"{tanggal} Desember {tahun}");
            break;
        default:
            Console.WriteLine("Bulan Invalid");
            break;
    }
}
else
{
    Console.WriteLine("Input harus valid");

}




