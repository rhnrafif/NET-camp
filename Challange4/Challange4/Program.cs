Console.WriteLine("Tuliskan angka");
int angka = Convert.ToInt32(Console.ReadLine());
int genap = angka % 2;

if (Convert.ToBoolean(genap) )
{
    Console.WriteLine("Ini angka ganjil");
}
else
{
    Console.WriteLine("Ini angka genap");
}