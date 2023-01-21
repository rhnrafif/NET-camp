Console.WriteLine("Tuliskan Jam");
int jam = Convert.ToInt32(Console.ReadLine());

if (jam >= 8 && jam <= 12 || jam >= 14 && jam <= 17)
{
    Console.WriteLine("JAM BELAJAR");
}else if (jam <= 24 && jam >= 1)
{
    Console.WriteLine("JAM ISTIRAHAT");
}else if ( jam > 24 || jam < 1)
{
    Console.WriteLine("WAKTU HANYA 24 JAM");
}