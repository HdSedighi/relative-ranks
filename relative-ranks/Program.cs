using System;
using System.Collections.Generic;

public class Solution
{
    public string[] FindRelativeRanks(int[] score)
    {
        int n = score.Length;
        string[] ranks = new string[n];

        // Create a list of tuples with score and index
        List<(int score, int index)> scoreIndexPairs = new List<(int score, int index)>();
        for (int i = 0; i < n; i++)
        {
            scoreIndexPairs.Add((score[i], i));
        }

        // Sort the list based on scores in descending order
        scoreIndexPairs.Sort((a, b) => b.score.CompareTo(a.score));

        // Assign ranks
        for (int i = 0; i < n; i++)
        {
            int index = scoreIndexPairs[i].index;

            if (i == 0)
            {
                ranks[index] = "Gold Medal";
            }
            else if (i == 1)
            {
                ranks[index] = "Silver Medal";
            }
            else if (i == 2)
            {
                ranks[index] = "Bronze Medal";
            }
            else
            {
                ranks[index] = (i + 1).ToString();
            }
        }

        return ranks;
    }
}

// Example usage
class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        int[] score1 = { 5, 4, 3, 2, 1 };
        string[] ranks1 = solution.FindRelativeRanks(score1);
        Console.WriteLine(string.Join(", ", ranks1)); // Output: Gold Medal, Silver Medal, Bronze Medal, 4, 5

        int[] score2 = { 10, 3, 8, 9, 4 };
        string[] ranks2 = solution.FindRelativeRanks(score2);
        Console.WriteLine(string.Join(", ", ranks2)); // Output: Gold Medal, 5, Bronze Medal, Silver Medal, 4
    }
}
