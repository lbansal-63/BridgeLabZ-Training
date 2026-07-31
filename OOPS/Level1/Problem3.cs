using System;

class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Copy Constructor
    public Person(Person p)
    {
        name = p.name;
        age = p.age;
    }

    public void Display()
    {
        Console.WriteLine($"{name} - {age}");
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person("Rahul", 25);
        Person p2 = new Person(p1);

        p1.Display();
        p2.Display();
    }
}