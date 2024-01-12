public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] m = new int[n];

        for (int i = 0; i < n; i++)
        {
            m[i] = int.Parse(Console.ReadLine());
            

        }

        int group = 1;

        for (int i = 1;i < n; i++) 
        {
            if (m[i] != m[i - 1])
                group++;
        }
        Console.WriteLine(group);
        
    }
}