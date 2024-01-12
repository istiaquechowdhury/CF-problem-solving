public class Program
{
    public static void Main()
    {
        char a = char.Parse(Console.ReadLine());    

        string s = Console.ReadLine();

        string Keyboard = "qwertyuiopasdfghjkl;zxcvbnm,./";

        string Keep = "";


        if (a == 'R')
        {
            for (int i = 0; i < s.Length; i++)
            {

                for (int j = 0; j < Keyboard.Length; j++)
                {
                    if (s[i] == Keyboard[j])
                    {
                        Keep = Keep + (Keyboard[j - 1]).ToString();
                    }
                }







            }

        }
        else if (a == 'L')
        {
            for (int i = 0; i < s.Length; i++)
            {

                for (int j = 0; j < Keyboard.Length; j++)
                {
                    if (s[i] == Keyboard[j])
                    {
                        Keep = Keep + (Keyboard[j + 1]).ToString();
                    }
                }
            }
        }


        Console.WriteLine(Keep);
    }
}