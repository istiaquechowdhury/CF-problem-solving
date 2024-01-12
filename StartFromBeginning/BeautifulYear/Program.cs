public class Program
{
    public static void Main()
    {
        string word = Console.ReadLine();

        if (IsDistinct(word))
        {
            Console.WriteLine("it is a distinct word");
        }
        else
        {
            Console.WriteLine("it is not a distinct word")
        }

       
        
    }


    public static bool IsDistinct(string word)
    {
     

        return word.Distinct().Count() == word.Length;    
    }
}