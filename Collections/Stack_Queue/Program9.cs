using System;

class Program
{
    static int CircularTour(int[] petrol, int[] distance)
    {
        int start = 0;
        int currentPetrol = 0;
        int totalPetrol = 0;

        for (int i = 0; i < petrol.Length; i++)
        {
            int gain = petrol[i] - distance[i];

            currentPetrol += gain;
            totalPetrol += gain;

            if (currentPetrol < 0)
            {
                start = i + 1;
                currentPetrol = 0;
            }
        }

        if (totalPetrol >= 0)
            return start;

        return -1;
    }

    static void Main()
    {
        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };

        Console.WriteLine(CircularTour(petrol, distance));
    }
}