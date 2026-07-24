using System;
public class Demo4
{
    public static void Main()
    {
        int pens= 14, stud = 3;

        int ans = pens / stud;
        int rem = pens % stud;
        

        Console.Write("The Pen Per Student is "+ans+" and the remaining pen not distributed is " + rem);
    }
}