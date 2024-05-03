using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ArrayProAndMeth
{
    public static void Main(string[] args)
    {
        int[] numbers1 = new int[5] { 1, 2, 3, 4, 5 };
        int[,] numbers2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        Console.WriteLine($"Length of array = {numbers1.Length}");
        Console.WriteLine($"Dyemention of array = {numbers1.Rank}");
        Console.WriteLine($"Dyemention of array = {numbers2.Rank}");
        Console.WriteLine(numbers1.Max());
        Console.WriteLine(numbers1.Min());
        Console.WriteLine(numbers1.Sum());
        Console.WriteLine(numbers1.Average());



    }
}