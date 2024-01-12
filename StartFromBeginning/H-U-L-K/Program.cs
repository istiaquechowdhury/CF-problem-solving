//public class Program
//{
//    public static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());

//        string[] Feelings = { "I hate", "I love" };

//        string result = "";

//        for(int i = 1; i <= n; i++)
//        {
//            result = result + Feelings[i % 2];

//            if (i < n)
//                result = result + " that";
//        }

//        result = result + " it";

//        Console.WriteLine(result);
//    }
//}

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] feelings = { "I love", "I hate" };

        string result = "";
        for (int i = 1; i <= n; i++)
        {
            result += feelings[i % 2];
            if (i < n)
                result += " that ";
        }

        result += " it";
        Console.WriteLine(result);
    }
}
