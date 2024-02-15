using System;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            int moves = GetMinMovesToRegularBracketSequence(n, s);
            Console.WriteLine(moves);
        }
    }

    static int GetMinMovesToRegularBracketSequence(int n, string s)
    {
        int moves = 0;
        int counter = 0;

        foreach (char bracket in s)
        {
            if (bracket == '(')
                counter++;
            else
                counter--;

            moves = Math.Min(moves, counter);
        }

        return Math.Abs(moves);
    }
}
