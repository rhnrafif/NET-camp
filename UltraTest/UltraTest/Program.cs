
public class Program
{
	static void Main(string[] args)
	{
		string[] food = new string[] { "Cook", "save", "taste", "aves", "vase", "state", "map" };
		var output = Anagram(food);

		foreach( var item in output)
		{
			Console.WriteLine(item);
		}
	}	

	static string[] Anagram(string[] input)
	{
		string[] result = new string[input.Length];

		for (int i = 0; i < input.Length; i++)
		{
			var text1 = String.Concat(input[i].OrderBy(w => w));
			for (int j = 0; j < input.Length; j++)
			{
				var texts = String.Concat(input[j].OrderBy(w => w));

				if (text1 != texts)
				{
					bool same1 = false;
					bool same2 = false;
					foreach (var item in text1)
					{
						if (texts.Contains(item))
							same1 = true;
						else
							same1 = false;
					}

					foreach (var item in texts)
					{
						if (text1.Contains(item))
							same2 = true;
						else
							same2 = false;
					}
					if (same1 || same2)
						result[i] += $" {input[j]}";
				}
				else
					result[i] += $" {input[j]}";
			}
		}
		result = result.Distinct().ToArray();
		return result;
	}

}
