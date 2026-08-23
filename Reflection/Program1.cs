using System;
using System.Reflection;

class Student
{
    public int Id;
    private string name;

    public Student()
    {
    }

    public Student(int id, string name)
    {
        Id = id;
        this.name = name;
    }

    public void Display()
    {
        Console.WriteLine("Student Details");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();

        Type type = Type.GetType(className);

        if (type == null)
        {
            Console.WriteLine("Class not found.");
            return;
        }

        Console.WriteLine("\nMethods:");
        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }

        Console.WriteLine("\nFields:");
        foreach (FieldInfo field in type.GetFields(
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Instance))
        {
            Console.WriteLine(field.Name);
        }

        Console.WriteLine("\nConstructors:");
        foreach (ConstructorInfo constructor in type.GetConstructors(
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Instance))
        {
            Console.WriteLine(constructor);
        }
    }
}