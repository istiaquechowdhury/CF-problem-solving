public class Program
{
    public static void Main()
    {

        string[] nk = Console.ReadLine().Split();
        int n = int.Parse(nk[0]);
        int k = int.Parse(nk[1]);

        for (int i = 0; i < k; i++)
        {
            if(n % 10 == 0)
            {
                n = n / 10;
            }
            else 
            {
                n--;
            }
        }
        Console.WriteLine(n);
    }
}