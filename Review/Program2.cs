using System;
using System.Collections.Generic;

class Program
{
    public static string MinWindow(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
            return "";

        Dictionary<char, int> need = new Dictionary<char, int>();

        foreach (char c in t)
        {
            if (need.ContainsKey(c))
                need[c]++;
            else
                need[c] = 1;
        }

        Dictionary<char, int> window = new Dictionary<char, int>();

        int required = need.Count;
        int formed = 0;

        int left = 0;

        int minLength = int.MaxValue;
        int minLeft = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];

            if (window.ContainsKey(c))
                window[c]++;
            else
                window[c] = 1;
            if (need.ContainsKey(c) &&
                window[c] == need[c])
            {
                formed++;
            }

            while (formed == required && left <= right)
            {
                int currentLength = right - left + 1;

                if (currentLength < minLength)
                {
                    minLength = currentLength;
                    minLeft = left;
                }

                char leftChar = s[left];

                window[leftChar]--;

                if (need.ContainsKey(leftChar) &&
                    window[leftChar] < need[leftChar])
                {
                    formed--;
                }

                left++;
            }
        }

        if (minLength == int.MaxValue)
            return "";

        return s.Substring(minLeft, minLength);
    }

    static void Main()
    {
        Console.WriteLine(MinWindow("ADOBECODEBANC", "ABC"));
        Console.WriteLine(MinWindow("a", "aa"));
    }
}