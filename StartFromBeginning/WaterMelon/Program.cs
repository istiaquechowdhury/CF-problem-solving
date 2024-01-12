using System;

public class Program
{
    public static void Main()
    {
        int UserInput = int.Parse(Console.ReadLine());

        if (UserInput % 2 == 0)
        {
            if(UserInput == 2)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }

            
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}