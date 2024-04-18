using System;

// Without constructor
class Car1
{
    public string? model;
    public string? color;
    public int year;
}
class ConsVsWithoutCons1
{
    public static void Main(string[] args)
    {
        Car1 Ford = new Car1();
        Ford.model = "Mustang";
        Ford.color = "red";
        Ford.year = 1969;
    }
}


// With constructor
class Car2
{
    public string? model;
    public string? color;
    public int year;
    public Car2(string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }
}
class ConsVsWithoutCons2
{
    public static void Main(string[] args)
    {
        Car2 Opel = new Car2("Astra", "White", 2005);
    }
}

