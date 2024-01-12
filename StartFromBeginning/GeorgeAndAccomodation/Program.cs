public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 0; i < n; i++) 
        {
            string[] PQ = Console.ReadLine().Split();

            int P = int.Parse(PQ[0]);
            int q = int.Parse(PQ[1]);   

            if ((q - P >=2))
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}