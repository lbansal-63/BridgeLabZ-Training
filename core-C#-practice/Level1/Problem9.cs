using System;
public class Demo4
{
    public static void Main()
    {
        int studFee,dis;
        Console.Write("Enter the student fee: ");
        studFee = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the University Discount: ");
        dis = Convert.ToInt32(Console.ReadLine());

        float disAmt = (studFee * dis) / 100.0;
        int disFee = studFee - disAmt;


        Console.Write(" The discount amount is INR " + disAmt + " and final discounted fee is INR " + disFee);
    }
}