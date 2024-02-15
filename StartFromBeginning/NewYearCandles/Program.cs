using System;

public class Program
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int[] arr = Array.ConvertAll(s, int.Parse);


        int a = arr[0];

        int b = arr[1];

        int finalResult = 0;
        int sum = 0;
        int result = a / b;

        finalResult = result;

        sum = result + (a % b);

        while (sum >= b)
        {
            result = (sum / b) + (sum % b);
            finalResult = finalResult + (sum / b);
            sum =  result;
            
        }
        Console.WriteLine(a + finalResult);
    }
}
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Read input values
//        string[] input = Console.ReadLine().Split();
//        int a = int.Parse(input[0]);
//        int b = int.Parse(input[1]);

//        // Calculate the total hours Vasily can light up the room
//        int totalHours = a;

//        // Keep making new candles from burned out candles until it's not possible
//        while (a >= b)
//        {
//            int newCandles = a / b; // Number of new candles that can be made
//            totalHours += newCandles; // Add the hours for the new candles
//            a = newCandles + (a % b); // Remaining candles after making new ones
//        }

//        // Output the result
//        Console.WriteLine(totalHours);
//    }
//}

//using System;

//public class Program
//{
//    public static void Main()
//    {
//        string[] s = Console.ReadLine().Split();

//        int[] arr = Array.ConvertAll(s, int.Parse);

//        int a = arr[0];
//        int b = arr[1];

//        int sum = 0;
//        int result = a / b;

//        sum = result;

//        while (result >= b)
//        {
//            a = result + (result % b);
//            result = a / b;
//            sum += result;
//        }

//        Console.WriteLine(a + sum);
//    }
//}

