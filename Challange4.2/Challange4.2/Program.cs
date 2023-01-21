Console.Write("Tuliskan kata : ");
string input = Console.ReadLine();

string hasil1;
if(input != null)
{
    for (var i = input.Length - 1; i >= 0; i--)
    {
        
        hasil1 = Convert.ToString(input[i]);
        if (hasil1 == input[i])
        {
            Console.Write(hasil1);
        }
    }

}


