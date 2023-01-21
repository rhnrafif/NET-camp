Console.WriteLine("Silahkan Tulisakan Nama :");
string nama = Console.ReadLine();

Console.WriteLine("Silahkan Tulisakan Peran :");
string peran = Console.ReadLine();

if (nama != "" && peran == "")
{
    Console.WriteLine("Peran harus diisi..");

}
else if (nama == "" && peran == "")
{
    Console.WriteLine("Nama dan Peran harus diisi..");
}else if (nama != "" && peran != "")
{
    if (nama != "" && peran == "Monster")
    {
        Console.WriteLine("Selamat Datang Monster Saitama, Hancurkan Semua Superhero Yang Ada");
        return;
    }
    if (nama != "" && peran == "Superhero")
    {
        Console.WriteLine("Selamat Datang Superhero Saitama, Kalahkan Semua Monster Di Muka Bumi");
        return;
    }

    Console.WriteLine("Selamat Datang Saitama, Pilih Peranmu Untuk Melanjutkan Game Ini");
}
Console.WriteLine("------------------------");
Console.WriteLine("Aplikasi selesai !");
