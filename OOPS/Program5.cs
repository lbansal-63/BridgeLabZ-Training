using System;
public class Program
{
    class Example
    {
        string name;
        int age;

        public Example(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Example(Example e) // copy constructor
        {
            this.name = e.name;
            this.age = e.age; 
        }

        public void getData()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("Age: {0}", this.age);
            Console.WriteLine("---------------------");
        }

    }

    public static void Main()
    {
        Example e1 = new Example("Laksha",21); 
        e1.getData();
        
        Example e2 = new Example(e1);
        e2.getData();
    }
}