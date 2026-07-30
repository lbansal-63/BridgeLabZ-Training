using System;
public class Program
{
    class Employee
    {
        public string name;
        public int id;
        public int salary;

        public Employee(string name,int id,int salary)
        {
            this.name = name;
            this.id = id; 
            this.salary = salary;
        }

        public void print()
        {
            Console.WriteLine ("------------------------");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine("------------------------");
        }
    }
    
    public static void Main()
    {
        Employee e1 = new Employee("Laksha", 1, 30000);
        Employee e2 = new Employee("Harman", 2, 25000);

        e1.print();
        e2.print(); 
    }
}