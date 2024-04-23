using System;

class PersonClass
{
    string name;
    int age;
    public PersonClass(string name, int age) : this(name) // Constructor Chaining
    {
        this.age = age;
    }
    // constructor overloading
    public PersonClass(string name) : this()
    {
        this.name = name;
    }
    // default constructor
    public PersonClass()
    {
        name = "test";
        age = 0;
    }
    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
class ConstructorChaining
{
    public static void Main(string[] args)
    {
        PersonClass person1 = new PersonClass("Alex", 33);
        person1.DisplayPersonInfo();

        PersonClass person2 = new PersonClass("Bob");
        person2.DisplayPersonInfo();

        PersonClass person3 = new PersonClass();
        person3.DisplayPersonInfo();
    }

}