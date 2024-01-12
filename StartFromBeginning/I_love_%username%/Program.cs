using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());


        string[] S = Console.ReadLine().Split();

        int[] arr = Array.ConvertAll(S, int.Parse);

        int AmazingPerformance = 0;
        int max = arr[0];
        int min = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                AmazingPerformance++;
            }
            else if (arr[i] < min)
            {
                min = arr[i];
                AmazingPerformance++;
            }
        }
        Console.WriteLine(AmazingPerformance);



    }
}


