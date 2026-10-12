using System;

public partial class Program
{
    static void InitializingArrray(int[] arr)
    {
        for (int i=0; i < arr.Length; i++)
        {
            Console.Write($"Input {i}th element: "); arr[i] = int.Parse(Console.ReadLine());
        }
    }

    static void DistinctTwoMax(int[] arr)
    {
        int? first = null;
        int? second = null;

        for (int i = 0; i < arr.Length; i++)
        {
            int x = arr[i];
            if (first ==null || x > first)
            {
                second = first;
                first = x;
            }
            else if (x < first &&(second == null || x > second)) second = x;
        }

        if (second == null) Console.WriteLine("NO");
        else
        {
            Console.WriteLine($"{first}\t{second}");
        }
    }

    private static void Main(string[] args)
    {
        Console.Write("Input n: "); int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        InitializingArrray(arr);
        DistinctTwoMax(arr);
    }
}

