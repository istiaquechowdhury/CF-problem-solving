public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split();

            for (int j = 1; j <s.Length ; j++)
            {
                if ((int.Parse(s[0]) < int.Parse(s[j])))
                {
                    count++;
                }

            }
            Console.WriteLine(count);
            count = 0;
        }

    }
}


