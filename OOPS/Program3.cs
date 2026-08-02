using System;
public class Program3
{

    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("This is constructor of base class!!"); 
        }
        public BaseClass(string message)
        {
            Console.WriteLine("This is constructor of base class!!"+message);
        }
    }

    class DerivedClass : BaseClass
    {
        public DerivedClass() : base("Hello Everyone!!")
        {
            Console.WriteLine("This is constructor of derived class!!");
        }
    }

    public static void Main()
    {
        DerivedClass dc = new DerivedClass();
        //DerivedClass dc = new DerivedClass();

    }
}