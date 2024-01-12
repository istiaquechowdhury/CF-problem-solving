using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] heights = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int minSwaps = 0;
        int maxHeightIndex = 0;
        int minHeightIndex = 0;

        for (int i = 0; i < n; i++)
        {
            if (heights[i] > heights[maxHeightIndex])
                maxHeightIndex = i;
            if (heights[i] <= heights[minHeightIndex])
                minHeightIndex = i;
        }

        // Calculate the number of swaps needed to move the tallest soldier to the front
        minSwaps += maxHeightIndex;

        // If the tallest soldier was in the first position, adjust the index for the shortest soldier
        if (maxHeightIndex == 0)
            minHeightIndex--;

        // Calculate the number of swaps needed to move the shortest soldier to the end
        minSwaps += (n - 1) - minHeightIndex;

        // If the tallest soldier and the shortest soldier are the same, subtract one swap
        if (maxHeightIndex > minHeightIndex)
            minSwaps--;

        Console.WriteLine(minSwaps);
    }
}
