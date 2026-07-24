using System;
public class Demo4
{
    public static void Main()
    {
        float sp=191,cp=129,profit, ProfPerc;

        profit = (sp - cp);
        ProfPerc = (profit / cp) * 100; 

        Console.Write("The Cost Price is INR "+cp+" and Selling Price is INR "+sp);
        Console.Write("The Profit is INR " + profit + " and Profit Percentage is INR " + ProfPerc);
    }
}