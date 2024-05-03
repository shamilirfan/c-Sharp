using System;

class PersoN
{
    public string? name; // readable and writeable
    private int age; // not readable and not writeable
    public int GetAge() // readable
    {
        return age;
    }
    public void SetAge(int a) // writeable
    {
        age = a;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {GetAge()}");
    }
}
class SetterAndGetter
{
    public static void Main(string[] args)
    {
        PersoN p1 = new PersoN();
        p1.name = "Bob";
        p1.SetAge(32);
        p1.DisplayInfo();

    }
}