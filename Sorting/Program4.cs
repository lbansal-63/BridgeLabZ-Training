using System;

class Program
{
    static void QuickSort(int[] prices, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(prices, low, high);

            QuickSort(prices, low, pivotIndex - 1);
            QuickSort(prices, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] prices, int low, int high)
    {
        int pivot = prices[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (prices[j] <= pivot)
            {
                i++;

                int temp = prices[i];
                prices[i] = prices[j];
                prices[j] = temp;
            }
        }

        int temp2 = prices[i + 1];
        prices[i + 1] = prices[high];
        prices[high] = temp2;

        return i + 1;
    }

    static void Main()
    {
        int[] prices = { 999, 299, 499, 199, 799 };

        QuickSort(prices, 0, prices.Length - 1);

        Console.WriteLine("Sorted Product Prices:");
        Console.WriteLine(string.Join(" ", prices));
    }
}