using System.Net.Security;
using System.Text;

public class Program
{
    public static void Main()
    {
        string Userinput = Console.ReadLine();

        StringBuilder SB = new StringBuilder(Userinput);

        string Vowels = "aeiouyAEIOUY";

        StringBuilder SB2 = new StringBuilder();

        for (int i = 0; i < SB.Length; i++)
        {
            
           
            
            if (!Vowels.Contains(SB[i]))
            {
                SB2.Append('.');
                SB2.Append(char.ToLower(SB[i]));
            }
        }
        Console.WriteLine(SB2.ToString());   
           
    }
}