using System; 
public class Program
{
    public static void Main()
    {
        try
        {
            //int a = 10;
            //int b = 0;
            //int c = a / b;
            //Console.WriteLine(c);

            string f = null;
            Console.WriteLine(f.Length); 
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch (Exception ex)
        {
            Console.Write(ex.Message);
        }

        finally // cleanup code 
        {
            Console.WriteLine("Finally Block Executed!!"); 
        }
    }
}