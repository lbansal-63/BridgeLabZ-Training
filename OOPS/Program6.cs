using System; 
public class Program
{
    class Example
    {
        public static int a;

        public string name; 
        public string fname;
        
        public Example(string name,string fname)
        {
            this.name = name; 
            this.fname = fname;
        }

        private Example()
        {

        }

        private Example(int a)
        {

        }

        public static int getInc()
        {
            return ++a; 
        }
        public static void getTime()
        {
            Console.WriteLine(DateTime.Now); 
        }
         
    }

    //class Example2 : Example
    //{

    //}

    public static void Main()
    {
        //Example e = new Example();
        Example.getTime();
        Example.a = 20; 
        Console.WriteLine(Example.getInc());

        Example e1 = new Example("Laksha", "Bansal"); 
        
    }
}