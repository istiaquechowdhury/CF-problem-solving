using System;

class Program
{
    static void Main()
    {
        int t = Convert.ToInt32(Console.ReadLine()); // Reading the number of test cases

        for (int i = 0; i < t; i++)
        {
            int k = Convert.ToInt32(Console.ReadLine()); // Reading the value of k for each test case
            int count = 0; // Counter for the number of elements found
            int currentNumber = 1; // Starting with 1

            while (count < k)
            {
                if (currentNumber % 3 != 0 && currentNumber % 10 != 3) // Checking if the number satisfies the conditions
                    count++; // Increment the count if the conditions are met

                currentNumber++; // Move to the next number
            }

            Console.WriteLine(currentNumber - 1); // Output the k-th element of the sequence
        }
    }
}
