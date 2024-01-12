using System;

public class Program
{
    public static void Main()
    {
        int Userinput =int.Parse(Console.ReadLine());

        for (int i = 0; i < Userinput; i++)
        {
           string output =  Avvrebiation(Console.ReadLine());

           Console.WriteLine(output);


        }
    }

    public static string Avvrebiation(string word)
    {
        
        if (word.Length > 10)
        {
            char FirstLetter = word[0];
            int Letterbetween = word.Length - 2;
            char Lastletter = word[word.Length - 1];

            return $"{FirstLetter}{Letterbetween}{Lastletter}";

        } 
        else
        {
            return word;
        }
    }
}