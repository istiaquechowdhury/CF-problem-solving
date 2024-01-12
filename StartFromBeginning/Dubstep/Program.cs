using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();

        string remove = "WUB";

        string result = s.Replace(remove, " ").Trim();

        Console.WriteLine(result);


    }
}