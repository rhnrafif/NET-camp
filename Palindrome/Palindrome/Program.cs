class Program
{
	//Untuk Pseudocode bisa di cek di fike Pseudocode.txt
	static void Main(string[] args)
	{
		string input;
		Console.Write("Enter a string : ");
		input = Console.ReadLine();

		var hasil = Palindrome(input);

		if (hasil)
			Console.WriteLine($"{input} is Palindrome");
		else
			Console.WriteLine($"{input} is Not Palindrome");
	}
	public static bool Palindrome(string input)
	{
		string output = string.Empty;
		input = input.ToLower();
		if (input != null)
		{
			for (int i = input.Length - 1; i >= 0; i--)
			{
				output += input[i].ToString();
			}
			if (output == input) return true;
			else return false;
		}
		else return false;
	}
}