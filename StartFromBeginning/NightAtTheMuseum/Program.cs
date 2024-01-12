using System;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine().Trim();
        int currentPos = 0; // 'a' is at position 0
        int rotations = 0;

        foreach (char c in input)
        {
            int targetPos = c - 'a';
            int diff = (targetPos - currentPos + 26) % 26; // Take modulo 26 to handle circular nature
            rotations += Math.Min(diff, 26 - diff); // Minimum of clockwise or counterclockwise rotations
            currentPos = targetPos;
        }

        Console.WriteLine(rotations);
    }
}
