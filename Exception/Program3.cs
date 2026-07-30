using System; 
public class IndexOutExp
{
    public static void Main()
    {
        int[] arr = new int[3];

        try
        {
            arr[0] = 11;
            arr[1] = 22;
            arr[2] = 33;
            arr[3] = 44;
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        } 

        catch(IndexOutOfRangeException ex)
        {
            Console.WriteLine("Array's range is exceeded");
            Console.WriteLine(ex.Message);
        }

    }
}