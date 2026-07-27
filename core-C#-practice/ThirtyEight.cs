using System; 
public class IndToMultiDigit
{
    public static void Main()
    {
        Console.Write("Enter the Multi-Digit number: "); 
        int num = Convert.ToInt32(Console.ReadLine());

        int digit = 0; 
        while (num != 0)
        {
            digit = num % 10;
            Console.Write(digit + " ");
            num /= 10;
        }
    }
}