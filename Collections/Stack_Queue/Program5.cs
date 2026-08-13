using System;
using System.Collections.Generic;

class Program
{
	static int[] MaxSlidingWindow(int[] nums, int k)
	{
		int n = nums.Length;

		if (n == 0 || k == 0)
			return new int[0];

		int[] result = new int[n - k + 1];

		LinkedList<int> deque = new LinkedList<int>();

		for (int i = 0; i < n; i++)
		{
			// Window se bahar wale indices remove
			while (deque.Count > 0 &&
				   deque.First.Value <= i - k)
			{
				deque.RemoveFirst();
			}

			// Smaller elements remove
			while (deque.Count > 0 &&
				   nums[deque.Last.Value] <= nums[i])
			{
				deque.RemoveLast();
			}

			deque.AddLast(i);

			// Window complete hone ke baad answer
			if (i >= k - 1)
			{
				result[i - k + 1] = nums[deque.First.Value];
			}
		}

		return result;
	}

	static void Main()
	{
		int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
		int k = 3;

		Console.WriteLine(
			string.Join(" ", MaxSlidingWindow(nums, k))
		);
	}
}