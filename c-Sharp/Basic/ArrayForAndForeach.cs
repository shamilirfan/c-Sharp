using System;

class ArrayForAndForeach
{
    public static void Main(string[] args)
    {
        string[] names;
        names = new string[5] { "Alex", "Sathi", "Rupa", "Bob", "Topu" };

        // print by for loop
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"{names[i]}");
        }

        // print by forEach
        foreach (string name in names)
        {
            Console.WriteLine($"{name}");
        }

    }
}

