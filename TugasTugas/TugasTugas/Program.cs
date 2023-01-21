class Program
{
    static void Main()
    {
        int[] arr = new int[8] { 7, 20, 39, 2, 48, 520, 5, 5 };
        int result;

        for (int i = 0; i < arr.Length - 2; i++)
        {
            for (int j = 0; j < arr.Length - 2; j++)
            {
                if (arr[j] == arr[j + 1])
                {
                    result = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = result;
                }
            }
        }
        foreach (var r in arr)
        {
            Console.WriteLine($" {r} ");
        }
        Console.WriteLine(arr);

    }
}