using System; 
public class Program
{
    class Person
    {
        public static string PersonName;
        public static int PersonAge;

        static Person()
        {
            PersonName = "Laksha";
            PersonAge = 21;
            Console.WriteLine("Static constructor invoked!!");
        }

        public Person()
        {
            Console.WriteLine("Default constructor invoked!!");
        }

        public void GetDetails()
        {
            Console.WriteLine("Person name is: {0}",PersonName); 
            Console.WriteLine("Person age is: {0}", PersonAge);
        }
    }

    public static void Main()
    {
        Person p1 = new Person(); 
        Person p2 = new Person();
        Person p = new Person();
        p.GetDetails();
    }
}