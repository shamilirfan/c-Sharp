using System;

class CopyClear
{
    public static void Main(string[] args)
    {
        int[] a = new int[5] { 1, 2, 3, 4, 5 };

        // copy method
        int[] b = new int[a.Length];
        Array.Copy(a, b, a.Length);

        foreach (int c in b)
        {
            Console.Write($"{c} ");
        }
        Console.WriteLine();


        // clear method
        Array.Clear(b, 0, b.Length);

        foreach (int c in b)
        {
            Console.Write($"{c} ");
        }


    }
}