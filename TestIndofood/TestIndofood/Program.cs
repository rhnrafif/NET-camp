class Program
{
	static void Main(string[] args)
	{
		int[] argsument = { 4, 5, 6, 7 };
		var res = Solution(argsument, 10);

		foreach(var i in res)
		{
			Console.Write($"{i}, ");
		}
	}

	public static int[] Solution(int[] nums, int target)
	{
		for(int i = 0; i < nums.Length; i++)
		{
			for(int j=i; j < nums.Length; j++)
			{
				int complement = target- nums[i];
				if (nums[j] == complement)
				{
					return new int[] { i, j };
				}
			}
		}
		throw new ArgumentException("No data");
	}
}