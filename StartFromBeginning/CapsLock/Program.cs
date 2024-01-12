public class Program
{
    public static void Main()
    {
        string Word = Console.ReadLine();

        if (IsCapsLocksError(Word))
        {
            Console.WriteLine(CorrectCapslockError(Word));
        }
        else
        {
            Console.WriteLine(Word);
        }

      
    }

    public static bool IsCapsLocksError(string word)
    {
        return word.ToUpper() == word || char.IsLower(word[0]) && word.Substring(1).ToUpper() == word.Substring(1);
    }

    public static string CorrectCapslockError(string word)
    {
        char[] c = new char[word.Length];
        for(int i = 0; i < word.Length; i++) 
        {

            if (char.IsUpper(word[i]))
            {
                c[i] = char.ToLower(word[i]);
            }
            else
            {
                c[i] = char.ToUpper(word[i]);
            }

        }

        return new string(c);
    }
}