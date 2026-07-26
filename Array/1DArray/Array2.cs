using System;

public class ArrayDemo2
{
    public static void Main()
    {
        int[] roll = new int[5];
        string[] name = new string[5];

        roll[0] = 1;
        name[0] = "Ankit Kumar";

        roll[1] = 2;
        name[1] = "Manisha Kumari";

        roll[2] = 3;
        name[2] = "Deepika Kumari";

        roll[3] = 4;
        name[3] = "Md Jawed Ali";

        roll[4] = 5;
        name[4] = "Akhilesh";

        Console.WriteLine(roll[0] + " " + name[0]);
        Console.WriteLine(roll[1] + " " + name[1]);
        Console.WriteLine(roll[2] + " " + name[2]);
        Console.WriteLine(roll[3] + " " + name[3]);
        Console.WriteLine(roll[4] + " " + name[4]);
    }
}
