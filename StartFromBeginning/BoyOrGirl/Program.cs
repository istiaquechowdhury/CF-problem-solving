public class Program
{
    public static void Main()
    {
        string Word = Console.ReadLine();
        
        int DistinctWord = Word.Distinct().Count();


        if (DistinctWord % 2 != 0)
        {
            Console.WriteLine("IGNORE HIM!");
        }
        else
        {
            Console.WriteLine("CHAT WITH HER!");
        }
    }

    
}