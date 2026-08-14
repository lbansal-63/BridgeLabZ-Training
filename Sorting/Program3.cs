using System;

class Program
{
    static void MergeSort(int[] prices, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            MergeSort(prices, left, mid);
            MergeSort(prices, mid + 1, right);

            Merge(prices, left, mid, right);
        }
    }

    static void Merge(int[] prices, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];

        int i = left;
        int j = mid + 1;
        int k = 0;

        while (i <= mid && j <= right)
        {
            if (prices[i] <= prices[j])
                temp[k++] = prices[i++];
            else
                temp[k++] = prices[j++];
        }

        while (i <= mid)
            temp[k++] = prices[i++];

        while (j <= right)
            temp[k++] = prices[j++];

        for (i = 0; i < temp.Length; i++)
            prices[left + i] = temp[i];
    }

    static void Main()
    {
        int[] prices = { 450, 120, 800, 250, 300 };

        MergeSort(prices, 0, prices.Length - 1);

        Console.WriteLine("Sorted Book Prices:");
        Console.WriteLine(string.Join(" ", prices));
    }
}