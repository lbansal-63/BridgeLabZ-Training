using System;
public class Program
{
    
    public static void Main()
    {
        int AccBal = 5000;
        Console.Write("Enter your Withdrawal Amount: ");
        int WithdrawAmt = Convert.ToInt32(Console.ReadLine()); 

        try
        {
            if (WithdrawAmt > AccBal)
            {
                throw new Exception("Paise kama jaake!!");
            }
            else
            {
                AccBal -= WithdrawAmt;
                Console.WriteLine($"Remaining Balance: {AccBal}");
                Console.WriteLine("Next Payment Kab Karoge!!");
            }
        }

        catch (Exception ex)
        {
            Console.Write(ex.Message);
        }
    }
}