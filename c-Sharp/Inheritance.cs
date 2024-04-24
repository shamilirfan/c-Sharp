using System;

class Vehicle
{
    public string brand = "Ford";
    public string sound()
    {
        return "Tuut, tuut!";
    }
}
class Car : Vehicle
{
    public string model = "Mustang";
}

class Inheritance
{
    public static void Main(string[] args)
    {
        Car car1 = new Car();
        Console.WriteLine($"Brand: {car1.brand}, Model: {car1.model}, Sound: {car1.sound()}");
    }
}
