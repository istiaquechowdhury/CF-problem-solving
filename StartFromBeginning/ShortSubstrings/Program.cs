using System.Globalization;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());  

        for(int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();

            string c = "" + s[0];

            for(int j = 1; j < s.Length; j++)
            {
                c = c + s[j];

                j++;
            }
            Console.WriteLine(c);   
        }
    }
}