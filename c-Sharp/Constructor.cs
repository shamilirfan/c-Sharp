using System;

class PersonClass2
{
    string name;
    int age;
    public PersonClass2()
    {

        name = "test";
        age = 0;
    }
    public PersonClass2(string n, int a)
    {
        name = n;
        age = a;
    }
    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}
class Constructor
{
    public static void Main(string[] args)
    {
        PersonClass2 person1 = new PersonClass2("Alex", 33);
        person1.DisplayPersonInfo();

        PersonClass2 person2 = new PersonClass2("Bob", 20);
        person2.DisplayPersonInfo();

        PersonClass2 person3 = new PersonClass2();
        person3.DisplayPersonInfo();

    }
}