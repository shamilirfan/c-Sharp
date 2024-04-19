using System;

interface IFlower
{
    void flowerColor();
}
class Rose : IFlower
{
    public void flowerColor()
    {
        Console.WriteLine($"The rose is red.");
    }
}
class Jasmine : IFlower
{
    public void flowerColor()
    {
        Console.WriteLine($"The jasmine is white.");
    }
}
class Interface
{
    public static void Main(string[] args)
    {
        Rose rose = new Rose();
        Jasmine jasmine = new Jasmine();

        rose.flowerColor();
        jasmine.flowerColor();

    }
}