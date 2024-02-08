using System;
using System.Linq;

public class WeightedString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Masukkan input:");
        string input = Console.ReadLine();
        
        string inputString = "abbcccd";
        int[] querieInput = { 1, 3, 9, 8 };

        var weights = inputString
            .Select((c, i) => new { Char = c, Weight = (i + 1) * (c - 'a' + 1) })
            .GroupBy(item => item.Char)
            .ToDictionary(g => g.Key, g => g.Sum(item => item.Weight));

        var results = querieInput.Select(q => weights.ContainsKey((char)(q + 'a' - 1)) ? "Yes" : "No").ToArray();
        
        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
}
