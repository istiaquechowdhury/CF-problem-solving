public class Program
{
    public static void Main()
    {
        
            string word = Console.ReadLine();
            string result = WordCapital(word);

            Console.WriteLine(result);
        

    


    }


    public static string WordCapital(string word)
    {
        string firstLetter = word.Substring(0, 1).ToUpper();
        string restOfString = word.Substring(1);

        return firstLetter + restOfString;  
    }
}