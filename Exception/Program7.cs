using System; 

class Program
{
    public static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;
            int c = a / b;

            string f = null;
            Console.WriteLine(f.Length);

            int[] arr = new int[3]; 
            arr[0] = 11; 
            arr[1] = 22; 
            arr[2] = 33; 
            arr[3] = 44; 
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }

        
    }
}