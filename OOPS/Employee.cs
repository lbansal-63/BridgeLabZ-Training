using System; 
public class Program
{
    class Employees
    {
        int EmpId;
        string EmpName;
        int EmpAge; 

        public Employees() // default constructor 
        {
            Console.WriteLine("Constructor Invokes!!"); 
        }

        public Employees(int EmpId,string EmpName,int EmpAge) // parameterized constructor
        {
            this.EmpId = EmpId; 
            this.EmpName = EmpName; 
            this.EmpAge = EmpAge;
        }

        public int getId() {
            return this.EmpId;
        }

        public string getName() {
            return this.EmpName; 
        }

        public int getAge()
        {
            return this.EmpAge;
        }
    }

    public static void Main()
    {
        Employees e3 = new Employees(); 
        Employees e1 = new Employees(123, "Laksha", 21);
        Employees e2 = new Employees(31, "Raghav", 23);

        Console.WriteLine(e1.getId()); 
        Console.WriteLine(e1.getName());
        Console.WriteLine(e1.getAge());

        Console.WriteLine("----------------"); 

        Console.WriteLine(e2.getId());
        Console.WriteLine(e2.getName());
        Console.WriteLine(e2.getAge());
    }
}