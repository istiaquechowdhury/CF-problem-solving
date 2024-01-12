public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());  

        for(int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();

            if (s[0] + s[1] + s[2] == s[3] + s[4] + s[5])
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}