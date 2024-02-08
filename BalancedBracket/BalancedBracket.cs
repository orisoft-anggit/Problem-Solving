using System;
using System.Collections.Generic;
using System.Linq;

public class BalancedBracket
{
    static void Main(string[] args)
    {
        Console.WriteLine("Masukkan input:");
        string input = Console.ReadLine();
        
        string output = CheckBracketsBalance(input) ? "YES" : "NO";
        Console.WriteLine($"Output: {output}");
    }

    static bool CheckBracketsBalance(string input)
    {
        Dictionary<char, char> bracketPair = new Dictionary<char, char>
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        var bracketAllLoop = input.Where(c => bracketPair.Keys.Contains(c) || bracketPair.Values.Contains(c));

        Stack<char> stack = new Stack<char>();

        foreach (char item in bracketAllLoop)
        {
            if (bracketPair.Keys.Contains(item))
            {
                stack.Push(item);
            }
            else if (stack.Any() && bracketPair[stack.Peek()] == item)
            {
                stack.Pop();
            }
            else
            {
                return false;
            }
        }
        return stack.Count == 0;
    }
}
