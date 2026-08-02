using System; 
public class ConstructorOverloading
{
    
    class Program
    {
        public Program()
        {
            Console.WriteLine("This is a First constructor!!");
        }

        public Program(int a,int b)
        {
            Console.WriteLine("This is a Second constructor!! {0}",(a+b));
        }

        public Program(int a, int b,int c)
        {
            Console.WriteLine("This is a third constructor!! {0}", (a + b + c));
        }

        public Program(string a, string b, string c)
        {
            Console.WriteLine("This is a fourth constructor!!");
        }
    }
     
    public static void Main()
    {
        Program p1 = new Program();
        Program p2 = new Program(20,30);
        Program p3 = new Program("A","B","C");
    }
}