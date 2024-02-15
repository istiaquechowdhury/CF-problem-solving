using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Read input values
        int k = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        // Check if k is not a divisor of the string length
        if (s.Length % k != 0)
        {
            Console.WriteLine("-1");
            return;
        }

        // Count occurrences of each character
        int[] charCount = new int[26];
        foreach (char c in s)
        {
            charCount[c - 'a']++;
        }

        // Reconstruct the string based on character counts
        string result = "";
        for (int i = 0; i < 26; i++)
        {
            if (charCount[i] % k != 0)
            {
                Console.WriteLine("-1");
                return;
            }

            result += new string((char)('a' + i), charCount[i] / k);
        }

        // Repeat the constructed string k times
        result = string.Concat(Enumerable.Repeat(result, k));

        // Output the result
        Console.WriteLine(result);
    }
}
