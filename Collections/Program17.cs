using System;
using System.Collections.Generic;

class Program
{
    static void AddVote(
        Dictionary<string, int> votes,
        string candidate)
    {
        if (votes.ContainsKey(candidate))
        {
            votes[candidate]++;
        }
        else
        {
            votes[candidate] = 1;
        }
    }

    static void Main()
    {
        Dictionary<string, int> votes =
            new Dictionary<string, int>();

        // Votes
        AddVote(votes, "Rahul");
        AddVote(votes, "Priya");
        AddVote(votes, "Rahul");
        AddVote(votes, "Aman");
        AddVote(votes, "Priya");
        AddVote(votes, "Priya");
        AddVote(votes, "Rahul");

        Console.WriteLine("VOTING RESULTS:");

        foreach (var item in votes)
        {
            Console.WriteLine(
                item.Key + " = " + item.Value);
        }

        // SortedDictionary
        Console.WriteLine("\nSORTED RESULTS:");

        SortedDictionary<string, int> sortedVotes =
            new SortedDictionary<string, int>();

        foreach (var item in votes)
        {
            sortedVotes[item.Key] = item.Value;
        }

        foreach (var item in sortedVotes)
        {
            Console.WriteLine(
                item.Key + " = " + item.Value);
        }

        // Winner
        string winner = "";
        int maxVotes = 0;

        foreach (var item in votes)
        {
            if (item.Value > maxVotes)
            {
                maxVotes = item.Value;
                winner = item.Key;
            }
        }

        Console.WriteLine(
            "\nWINNER: " + winner);

        Console.WriteLine(
            "VOTES: " + maxVotes);
    }
}