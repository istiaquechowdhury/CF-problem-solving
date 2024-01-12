public class Program
{
    public static void Main()
    {
        string word = Console.ReadLine();

        int CountUpper = 0;
        int CountLower = 0;


        for (int i = 0; i < word.Length; i++)
        {
            if (char.IsUpper(word[i]))
            {
                CountUpper++;
            }

            else
            {
                CountLower++;
            }
        }
        if(CountUpper > CountLower)
        {
            word.ToUpper();
            Console.WriteLine(word.ToUpper());
        }
        else
        {
            word.ToLower();
            Console.WriteLine(word.ToLower());
        }
    }
}