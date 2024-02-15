using System;

class Program
{
    static void Main()
    {
        // Read the input
        int x = int.Parse(Console.ReadLine());

        // Calculate the minimum number of bacteria needed
        int result = MinimumBacteria(x);

        // Print the result
        Console.WriteLine(result);
    }

    static int MinimumBacteria(int x)
    {
        int count = 0;

        // Keep dividing by 2 until the target is reached
        while (x > 0)
        {
            // If the least significant bit is 1, we need to add one bacterium
            if ((x & 1) == 1)
            {
                count++;
            }

            // Right shift x by 1 (equivalent to dividing by 2)
            x >>= 1;
        }

        return count;
    }
}
