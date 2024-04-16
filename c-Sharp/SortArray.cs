using System;

class SortArray
{
    public static void Main(string[] args)
    {
        int[] numbers1 = new int[5] { 5, 1, 3, 2, 4 };
        int[] numbers2 = new int[5] { 1, 2, 3, 4, 5 };

        // IndexOf
        int indexof = Array.IndexOf(numbers2, 3);
        Console.WriteLine($"index of 3 = {indexof}");


        // exists
        bool exists1 = Array.Exists(numbers2, number => number == 5);
        bool exists2 = Array.Exists(numbers2, number => number == 6);
        Console.WriteLine($"{exists1}");
        Console.WriteLine($"{exists2}");


        // sort
        Array.Sort(numbers1);
        foreach (int number1 in numbers1)
        {
            Console.Write($"{number1} ");
        }
        Console.WriteLine();


        // reverse
        Array.Reverse(numbers2);
        foreach (int number2 in numbers2)
        {
            Console.Write($"{number2} ");
        }



    }
}