using System;

public class Program
{
    public static void Main()
    {
        int Count  = 0;
        int Userinput = int.Parse(Console.ReadLine());

        for (int i = 0; i < Userinput; i++) 
        {
            string[] input = Console.ReadLine().Split();

            int p = int.Parse(input[0]);
            int v = int.Parse(input[1]);
            int t = int.Parse(input[2]);

            if (p + v + t >= 2)
            {
                Count = Count + 1;
            }
        }

       

        Console.WriteLine(Count);
    }


}