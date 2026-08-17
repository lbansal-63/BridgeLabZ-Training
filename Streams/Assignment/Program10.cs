using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class WordCounter
{
    static void Main()
    {
        string fileName = "input.txt";

        Dictionary<string, int> wordCount =
            new Dictionary<string, int>(
                StringComparer.OrdinalIgnoreCase);

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    // Extract words and ignore punctuation
                    MatchCollection words =
                        Regex.Matches(line, @"\b[\p{L}\p{N}']+\b");

                    foreach (Match match in words)
                    {
                        string word = match.Value.ToLowerInvariant();

                        if (wordCount.ContainsKey(word))
                            wordCount[word]++;
                        else
                            wordCount[word] = 1;
                    }
                }
            }

            var topFive = wordCount
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Take(5);

            Console.WriteLine("Top 5 Most Frequently Used Words:");

            foreach (var item in topFive)
            {
                Console.WriteLine(
                    item.Key + " : " + item.Value);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}