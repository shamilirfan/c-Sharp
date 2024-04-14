using System;

class Person
{
    public string name; // readable and writeable
    private int age; // not readable and not writeable
    public void SetAge(int a) // writeable
    {
        age = a;
    }
    public int GetAge() // readable
    {
        return age;
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
        Person p1 = new Person();
        p1.name = "Bob";
        p1.SetAge(32);
        p1.DisplayInfo();

    }
}