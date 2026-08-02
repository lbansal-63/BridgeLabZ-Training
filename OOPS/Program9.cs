using System; 
public class Program
{
    //struct Employee
    //{
    //    public int salary;
    //    public int age; 
    //}

    class Employee
    {
        public int salary;
        public int age;
    }

    public static void Main()
    {
        Employee e = new Employee();
        e.salary = 5000;
        e.age = 23; 

        Employee e1 = e;
        Employee e2 = e;
        e.age = 25;
        Console.WriteLine(e.age);
        Console.WriteLine(e1.age);
        Console.WriteLine(e2.age);
    }
}