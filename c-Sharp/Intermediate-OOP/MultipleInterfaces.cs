using System;

interface IFlower
{
    void flowerColor();
}
interface ILook
{
    void flowerLook();
}
class Rose : IFlower, ILook
{
    public void flowerColor()
    {
        Console.WriteLine($"The rose is red.");
    }
    public void flowerLook()
    {
        Console.WriteLine($"Look beautiful!");
    }
}
class Jasmine : IFlower, ILook
{
    public void flowerColor()
    {
        Console.WriteLine($"The jasmine is white");
    }
    public void flowerLook()
    {
        Console.WriteLine($"Look beautiful!");
    }
}
class MultipleInterfaces
{
    public static void Main(string[] args)
    {
        Rose rose = new Rose();
        Jasmine jasmine = new Jasmine();

        rose.flowerColor();
        rose.flowerLook();
        jasmine.flowerColor();
        jasmine.flowerLook();

    }
}