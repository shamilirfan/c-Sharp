using System;

class Human
{
    public string? Name { get; set; }
    public string? Type { get; set; }
    public Human(string Name, string Type)
    {
        this.Name = Name;
        this.Type = Type;
    }
    public void DisplayInfo_1()
    {
        Console.WriteLine($"Name: {this.Name}, Type: {this.Type}");
        Console.WriteLine($"Name: {Name}, Type: {Type}");
    }
    public static void DisplayInfo_2(string Name, string Type)
    {
        Console.WriteLine($"Name: {Name}, Type: {Type}");
    }
}
class Static
{
    public static void Main(string[] args)
    {
        Human human = new Human("Nowshin", "Human");
        human.DisplayInfo_1();

        // Direct Access
        Human.DisplayInfo_2("Nowshin", "Human");

    }
}