using System;

class Dubstep
{
    public static void Main(string[] args)
    {
        string[] input1 = Console.ReadLine().Split(' ');
        string[] a = new string[input1.Length];

        for (int i = 0; i < input1.Length; i++)
        {
            a[i] = input1[i].Replace("WUB", " ");
        }

        foreach (string item in a)
        {
            Console.Write($"{item.TrimStart()}");
        }
    }
}