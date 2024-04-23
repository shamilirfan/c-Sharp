using System;

class Person
{
    public string firstName;
    public string middleName;
    public string lastName;
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public Person(string firstName, string middleName, string lastName)
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }
    public string FullName()
    {
        string fullName = FirstName + " " + MiddleName + " " + LastName;
        return fullName;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Person("Md", "Aminul", "Islam");
        string fullName = person1.FullName();

        Console.WriteLine($"{fullName}");
    }
}
