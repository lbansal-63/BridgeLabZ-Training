using System;
public class Demo4
{
    public static void Main()
    {
        int studFee = 125000, dis = 10;

        float disAmt = (studFee*dis)/100.0;
        int disFee = studFee-disAmt;


        Console.Write(" The discount amount is INR "+disAmt+" and final discounted fee is INR " + disFee);
    }
}