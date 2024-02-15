public class Program
{
    public static void Main()
    {

        string[] s = Console.ReadLine().Split();

        int n = int.Parse(s[0]);
        int x = int.Parse(s[1]);

        int Count = 0;


        for(int i = 1; i <= n;  i++)
        {
            if (x % i == 0)
            {
                if(x % i <= n)
                Count++;
            }
        }
        Console.WriteLine(Count);
    }
}