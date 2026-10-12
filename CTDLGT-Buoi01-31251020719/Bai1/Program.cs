using System;

public partial class Program
{
    static void MaxMinMean(int a, int b, int c)
    {
        int max = a;
        int min = a;
        double mean = (a + b + c) / 3.0;
        if (b > max) max = b;
        else if (c > max) max = c;

        if (b < min) min = b;
        else if (c < min) min = c;
        Console.WriteLine($"Max: {max} | Min: {min}| Mean: {mean:F2}");
    }

    private static void Main(string[] args)
    {
        Console.Write("Input a: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Input b: "); int b = int.Parse(Console.ReadLine());
        Console.Write("Input c: "); int c = int.Parse(Console.ReadLine());
        MaxMinMean(a, b, c);
    }
}

