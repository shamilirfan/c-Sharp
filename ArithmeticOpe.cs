using System;

class Test1
{
    public static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 3;

        Console.WriteLine("addition: " + (num1 + num2));
        Console.WriteLine("subtraction: " + (num1 - num2));
        Console.WriteLine("multiplication: " + num1 * num2);
        Console.WriteLine("division: " + num1 / num2);
        Console.WriteLine("modulus: " + num1 % num2);
        //
        double sum = (double)num1 / num2;
        Console.WriteLine(sum);
        Console.WriteLine(sum.ToString("F2")); // this is for formatting


        // more formatting
        Console.WriteLine($"{num1} + {num2} =  {num1 + num2}");
        Console.WriteLine($"{num1} - {num2} =  {num1 - num2}");
        Console.WriteLine($"{num1} * {num2} =  {num1 * num2}");
        Console.WriteLine($"{num1} / {num2} =  {num1 / num2}");
        Console.WriteLine($"{num1} % {num2} =  {num1 % num2}");
        //
        double sum = (double)num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {sum}");
        Console.WriteLine($"{num1} / {num2} = {sum.ToString("F2")}");

        // or
        int result = num1 + num2;
        Console.WriteLine("{0} + {1} = {2}", num1, num2, result);

    }
}