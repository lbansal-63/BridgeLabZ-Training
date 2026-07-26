using System; 

public class JaggedArray
{
    public static void Main()
    {
        int[][] arr = new int[3][];
        arr[0] = new[] { 11, 22, 33, 44, 76, 34, 12, 22}; // 8 col
        arr[1] = new[] { 55, 66, 77, 88, 34, 21, 22}; // 7 col
        arr[2] = new[] { 99, 34, 22}; // 6 col

        Console.WriteLine(arr[0][4]);
        //Console.WriteLine(arr[2][3]); -> gives exception 

        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j]+"\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        foreach (int[] items in arr)
        {
            foreach(int i in items)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}