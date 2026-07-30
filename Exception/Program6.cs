using System; 
public class program
{
    public static void Main()
    {
        try
        {
            //string a = null;
            //Console.WriteLine(a.Length);

            //int[] arr = new int[3]; 
            //arr[0] = 11;
            //arr[1] = 22;
            //arr[2] = 33; 
            //arr[3] = 44; 

            string a = "Laksha";
            int i = Convert.ToInt32(a);
            Console.WriteLine(i);
        }

        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}