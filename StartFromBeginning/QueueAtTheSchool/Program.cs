using System.Net.Security;
using System.Runtime.Serialization.Formatters;

public class Program
{
    public static void Main()
    {
        string[] nk = Console.ReadLine().Split();

        int n = int.Parse( nk[0]);

        int T = int.Parse(nk[1]);   

        string S = Console.ReadLine();

        char[] chars = S.ToCharArray();

        for (int i = 0; i < T ; i++) 
        {
            for(int j = 0; j < n -1 ; j++)
            {
                if (chars[j] == 'B' && chars[j+1] == 'G')
                {
                    char temp = chars[j];

                    chars[j] = chars[j+1];
                    chars[j+1] = temp;

                    j++;
                }
            }
        }

        Console.WriteLine(chars);
    }
}