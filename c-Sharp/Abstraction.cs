using System;

abstract class Flower // Abstraction class
{
    public abstract void color();
    public void look()
    {
        Console.WriteLine($"Beautiful!");
    }
}
class Rose : Flower // Derived class(inherit from Flower)
{
    public override void color()
    {
        Console.WriteLine($"The rose is red.");
    }
}
class Jasmine : Flower
{
    public override void color()
    {
        Console.WriteLine($"The jasmine is white.");
    }
}

class Abstraction
{
    public static void Main(string[] args)
    {
        Rose rose = new Rose();
        rose.color();
        rose.look();

        Jasmine jasmine = new Jasmine();
        jasmine.color();
        jasmine.look();

    }
}