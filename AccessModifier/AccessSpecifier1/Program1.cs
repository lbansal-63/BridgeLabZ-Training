using System;

namespace AccessSpecifier1
{
    public class class1
    {
        internal void show()
        {
            Console.WriteLine("This is a internal method2..."); 
        } 
    }


    class Program1 : class1
    {
        static void Main(string[] args)
        {
            Program1 c = new Program1();
            c.show();
            Console.ReadLine();
        }
    }
}