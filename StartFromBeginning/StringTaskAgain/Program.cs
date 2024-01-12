public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine().ToLower();

        string result = "";


        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'y')
            {
                continue;
            }
            else
            {
                result = result + "." + s[i];
               
            }
        }
        Console.WriteLine(result);
    }
}