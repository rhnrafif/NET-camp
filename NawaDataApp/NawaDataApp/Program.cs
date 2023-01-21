using System;
namespace Nawadata
{
	class Program
	{
		static void Main()
		{
			bool showMenu = true;
			while (showMenu)
			{
				Console.WriteLine();
				Console.WriteLine(" FEATURE ");
				Console.WriteLine("1. Sort Characters");
				Console.WriteLine("2. PSBB Bus Wedding Counter");
				Console.WriteLine("3. Exit");

				Console.Write("Choose the Feature : ");

				switch (Console.ReadLine())
				{
					case "1":
						SortChar();
						showMenu = true;
						break;
					case "2":
						PsbbBusCount();
						showMenu = true;
						break;
					case "3":
						showMenu = false;
						break;
					default:
						showMenu = true;
						break;
				}
			}
		}

		//Sort Character
		public static void SortChar()
		{
			Console.WriteLine("Input your Text :");
			string inp = Console.ReadLine();

			var vowel = ProcVowel(inp);
			var consonant = ProcConsonant(inp);

			Console.WriteLine();
			Console.WriteLine("Vowel Characters :");
			Console.WriteLine(vowel);

			Console.WriteLine();
			Console.WriteLine("Consonant Characters :");
			Console.WriteLine(consonant);
		}
		static string ProcVowel(string input)
		{
			string text = "";
			string vowel = "aiueo";
			
			input = input.Replace(" ", "");
			var res = input.ToArray();
			Array.Sort(res);
			foreach (var item in res)
			{
				if (vowel.Contains(item))
				{
					text += item;
				}
			}
			return text;
		}

		static string ProcConsonant(string input)
		{
			string text = "";
			string vowel = "aiueo";
			input = input.Replace(" ", "");
			var res = input.ToArray();			
			foreach (var item in res)
			{
				if (!vowel.Contains(item))
				{
					text += item;					
				}
			}
			return text;
		}

		//PSBB Bus Count For Wedding
		public static void PsbbBusCount()
		{
			Console.WriteLine("Input the number of families :");
			int familyNum = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Input the number of member in the family : ");
			string memberData = Console.ReadLine();
			
			var result = BusCount(familyNum, memberData);

			if (result != 0)
				Console.WriteLine($"Minimum bus required is : {result}");
			else
				Console.WriteLine("Input must be equal with count of family");
			
		}

		static int BusCount(int familyNum, string familyMember)
		{
			char[] familyMemberList = familyMember.Replace(" ", "").ToCharArray();
			int[] memberData = new int[familyMemberList.Length];

			for (int i = 0; i < familyMemberList.Length; i++)
			{
				memberData[i] = Convert.ToInt32(familyMemberList[i].ToString());
			}

			if (familyNum == memberData.Length)
			{
				int bus = 0;
				int exValue = 0;

				for (int i = 0; i < memberData.Length; i++)
				{
					if (exValue <= 4)
					{
						int difference = 4 - exValue;
						if (memberData[i] <= difference)
						{
							exValue += memberData[i];
							if (exValue == 4)
							{
								exValue = 0;
								bus++;
							}
						}
						else
						{
							if (memberData[i] == memberData[0])
							{
								bus++;
								difference = memberData[i] - 4;
								exValue += difference;
							}
							else
							{
								int innerValue = memberData[i] - difference;
								if (innerValue >= 4)
								{
									bus += 2;
									exValue = innerValue - 4;
								}
								else
								{
									exValue = innerValue;
									bus++;
								}
							}
						}
					}
					if (i == memberData.Length - 1 && exValue != 0)
					{
						bus++;
					}
				}
				return bus;
			}
			else return 0;
		}
	}
}
