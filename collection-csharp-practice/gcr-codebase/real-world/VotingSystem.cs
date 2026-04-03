using System;
using System.Collections.Generic;

class VotingSystem
{
    static void Main()
    {
        Dictionary<string, int> votes = new Dictionary<string, int>();
        SortedDictionary<string, int> sortedResults = new SortedDictionary<string, int>();
        List<string> voteOrder = new List<string>();

        Console.WriteLine("Enter number of votes:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Candidate name:");
            string name = Console.ReadLine();
            voteOrder.Add(name);

            if (votes.ContainsKey(name))
                votes[name]++;
            else
                votes[name] = 1;
        }

        foreach (var v in votes)
            sortedResults[v.Key] = v.Value;

        Console.WriteLine("Sorted Results:");
        foreach (var v in sortedResults)
            Console.WriteLine(v.Key + " " + v.Value);

        Console.WriteLine("Vote Order:");
        foreach (string v in voteOrder)
            Console.WriteLine(v);
    }
}
