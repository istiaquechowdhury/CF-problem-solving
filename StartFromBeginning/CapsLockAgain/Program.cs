public class Program
{
    public static void Main()
    {
        string word = Console.ReadLine();

        if(IsCapslockError(word))
        {
           Console.WriteLine(CorrectError(word)); 
        }
        else
        {
            Console.WriteLine(word);
        }

    }


    public static bool IsCapslockError(string word)
    {
        if (word == word.ToUpper() || word.Substring(0,1).ToLower() == word.Substring(0,1) && word.Substring(1).ToUpper() == word.Substring(1))
        {
            return true;
        }

        return false;
      
    }

    public static string CorrectError(string word)
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