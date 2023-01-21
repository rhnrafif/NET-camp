using System.CodeDom.Compiler;
using System.Xml;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Input the number of families :");
		int family = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Input the number of member in the family : ");
		string input = Console.ReadLine();
		var inputMember = input.Replace(" ", "").ToCharArray();

		int[] inPUT = new int[inputMember.Length];
		for(int i = 0; i < inputMember.Length; i++)
		{
			inPUT[i] = Convert.ToInt32(inputMember[i].ToString());
		}

		if(family == inPUT.Length)
		{
			int bus = 0;
			int ouput = 0;
			
			for (int i = 0; i < inPUT.Length; i++)
			{
				if(ouput <= 4)
				{
					int selisih = 4 - ouput;
					if (inPUT[i] <= selisih)
					{
						ouput += inPUT[i];
						if (ouput == 4)
						{
							ouput = 0;
							bus++;
						}
					}
					else
					{
						if (inPUT[i] == inPUT[0])
						{
							bus++;
							selisih = inPUT[i] - 4;
							ouput += selisih;
						}
						else
						{
							int masuk = inPUT[i] - selisih;
							if (masuk >= 4)
							{
								bus += 2;
								ouput = masuk - 4;
							}
							else
							{
								ouput = masuk;
								bus ++;
							}
						}
						
					}					
				}
				if (i == inPUT.Length - 1 && ouput != 0)
				{
					bus++;
				}
			}

			Console.WriteLine($"Bus Yang dibutuhkan : {bus}");
		}
		else
		{
			Console.WriteLine("Berlebihan");
		}
		

	}

	private int CountBus(int family, int member)
	{
		return 0;
	}
}