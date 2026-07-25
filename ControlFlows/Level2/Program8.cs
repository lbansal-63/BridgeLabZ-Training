using System;

class Friends
{
    static void Main()
    {
        int amarAge, akbarAge, anthonyAge;
        double amarHeight, akbarHeight, anthonyHeight;

        // Input Ages
        Console.Write("Enter Amar's age: ");
        amarAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Akbar's age: ");
        akbarAge = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        anthonyAge = Convert.ToInt32(Console.ReadLine());

        // Input Heights
        Console.Write("Enter Amar's height: ");
        amarHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Akbar's height: ");
        akbarHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Anthony's height: ");
        anthonyHeight = Convert.ToDouble(Console.ReadLine());

        // Find Youngest
        if (amarAge < akbarAge && amarAge < anthonyAge)
        {
            Console.WriteLine("Youngest Friend: Amar");
        }
        else if (akbarAge < amarAge && akbarAge < anthonyAge)
        {
            Console.WriteLine("Youngest Friend: Akbar");
        }
        else
        {
            Console.WriteLine("Youngest Friend: Anthony");
        }

        // Find Tallest
        if (amarHeight > akbarHeight && amarHeight > anthonyHeight)
        {
            Console.WriteLine("Tallest Friend: Amar");
        }
        else if (akbarHeight > amarHeight && akbarHeight > anthonyHeight)
        {
            Console.WriteLine("Tallest Friend: Akbar");
        }
        else
        {
            Console.WriteLine("Tallest Friend: Anthony");
        }
    }
}
