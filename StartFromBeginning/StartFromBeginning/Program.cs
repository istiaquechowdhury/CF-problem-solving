using System;

public class Program
{
    public static void Main()
    {
           
         Program p = new Program(); 
         int input = p.IsEvenOrOdd(int.Parse(Console.ReadLine()));
         if (input % 2 == 0) 
         {
            p.Even(input);
         }
         else
         {
            p.Odd(input);   

         }
         

        
    }

    public int IsEvenOrOdd(int number)
    {
        int number1 = number;
        if(number1 % 2 == 0)
        {
            Console.WriteLine($"The number {number1} is even number"); 
            return number1;
        }
        else
        {
            Console.WriteLine($"The number {number1} is odd number");
            return number1;
        }
    }

    public void Even(int Target)
    {
        for (int i = 0; i < Target; i++)
        {
           
            Console.WriteLine(i);
            i++;

        }
    }

    public void Odd(int Target)
    {
        for (int i = 1; i < Target; i++)
        {
            Console.WriteLine(i);
            i++;
        }

    }


}