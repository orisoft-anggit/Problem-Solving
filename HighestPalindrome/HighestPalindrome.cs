using System;
using System.Linq;

public class HighestPalindrome
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Masukkan input:");
        string input = Console.ReadLine();

        string string1 = "3943";
        int k1 = 1;
        Console.WriteLine($"Input: string = {string1}, k = {k1}");
        Console.WriteLine( $"Output: {FindHighestPalindrome(string1, k1)}");

        string string2 = "3943";
        int k2 = 2;
        Console.WriteLine($"Input: string = {string2}, k = {k2}");
        Console.WriteLine($"Output: {FindHighestPalindrome(string2, k2)}");
    }
    
    public static string FindHighestPalindrome(string str, int k)
    {
        if (k < 0)
            throw new ArgumentException("K haruslah bilangan non-negatif.");

        if (IsPalindrome(str))
            return str;

        if (k == 0)
            return "-1";

        char maxChar = str.Max();
        if (str.Length == 1)
            return maxChar.ToString();

        if (str[0] != maxChar)
        {
            var nextMax = FindHighestPalindrome(str.Substring(1), k);
            if (nextMax != "-1")
                return maxChar + nextMax;
        }

        var nextMax2 = FindHighestPalindrome(str.Substring(0, str.Length - 1), k - 1);
        return maxChar + nextMax2 + maxChar;
    }

    private static bool IsPalindrome(string str)
    {
        return str.SequenceEqual(str.Reverse());
    }
}
