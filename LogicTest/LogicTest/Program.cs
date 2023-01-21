//public class Program
//{

//	static void Main()
//	{		

//	Console.WriteLine("Tuliskan Romawi");
//		var res = Console.ReadLine();

//		var result = RomanToInt(res);
//		Console.WriteLine(result);
//	}

//	static int RomanToInt(string s)
//	{
//		Dictionary<char, int> dict =
//	new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };

//	char[] ch = s.ToCharArray();
//		int result = 0;
//		int intVal, nextIntVal;

//		for (int i = 0; i < ch.Length; i++)
//		{
//			intVal = dict[ch[i]];

//			if (i != ch.Length - 1)
//			{
//				nextIntVal = dict[ch[i + 1]];
//				if (nextIntVal > intVal)
//				{
//					intVal = nextIntVal - intVal;
//					i = i + 1;
//				}
//			}
//			result = result + intVal;
//		}
//		return result;
//	}
//}

using System.Collections;
using System.Collections.Specialized;

//public class Program
//{
//	static void Main()
//	{
//		string[] str = new string[] { "flower", "flowers", "flowers" };
//		var result = LongestCommonPrefix(str);

//		Console.WriteLine(result);
//	}
//	static string LongestCommonPrefix(string[] strs)
//	{
//		if(strs.Length == 1)
//			return strs[0];

//		string result = "";
//		string value = strs[0];
//		int flag = 0;

//		for(int i = 0; i < value.Length; i++)
//		{
//			for(int j = 1; j < strs.Length; j++)
//			{
//				string nValue = strs[j];
//				if(i >= strs[j].Length)
//				{
//					flag = 1;
//					break;
//				}
//				if (value[j] != nValue[j])
//				{
//					flag = 1;
//					break;
//				}
//			}
//			if(flag == 0)
//			{
//				result += value[i];
//			}
//		}
//		return result;

//	}
//}

//public class Program
//{
//	static void Main()
//	{
//		int[] input = new int[] { -1, 0, 1, 2, -1, -4 };

//		var result = ThreeSum(input);
//	}

//	static IList<IList<int>> ThreeSum(int[] nums)
//	{
//		List<IList<int>> answer = new List<IList<int>>();
//		Array.Sort(nums);

//		for( int i = 0; i < nums.Length -2; i++)
//		{
//			if(i == 0 || (i > 0 && nums[i] != nums[i - 1]))
//			{
//				int start = i + 1;
//				int end = nums.Length - 1;
//				int sum = 0 - nums[i];

//				while(start < end)
//				{
//					if (nums[start] + nums[end] == sum)
//					{
//						var list = new List<int>();
//						list.Add(nums[i]);
//						list.Add(nums[start]);
//						list.Add(nums[end]);

//						answer.Add(list);

//						while (start < end && nums[start] == nums[start + 1]) start++;
//						while (start < end && nums[end] == nums[end - 1]) end--;

//						start++;
//						end--;
//					}
//					else if (nums[start] + nums[end] < sum)
//					{
//						start++;
//					}
//					else
//						end--;
//				}
//			}
//		}
//		return answer;
//	}
//}

public class Program
{
	static void Main()
	{
		string a = "title";
		string b = "paper";

		var res = IsoMorphic(a,b);
		Console.WriteLine(res);
	}

	static int[] RunningSum(int[] nums)
	{
		int sum = 0;
		return nums.Select( n => sum += n).ToArray();
	}

	static int PivotIndex(int[] nums)
	{
		int sum = 0;
		int nTotal = nums.Sum();

		for(int i = 0; i< nums.Length; i++)
		{
			if( sum == nTotal - (sum + nums[i]))
			{
				return i;
			}
			sum += nums[i];
		}
		return -1;
	}
	static bool IsoMorphic(string s, string t)
	{
		Dictionary<char, char> map = new Dictionary<char, char>();
		for(int i=0; i< s.Length; i++)
		{
			if (!map.ContainsKey(s[i]) && !map.ContainsValue(t[i]))
			{
				map.Add(s[i], t[i]);
			}
			else
			{
				if (!map.ContainsKey(s[i])) return false;
				if (map[s[i]] != t[i]) return false;
			}			
		}
		return true;
	}

}