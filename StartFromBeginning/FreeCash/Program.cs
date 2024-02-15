public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());


        int[] h = new int[n];

        int[] m = new int[n];

        int Count = 1;

        int maxcount = 1;   


        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split();

            

            h[i] = int.Parse(s[0]);
            m[i] = int.Parse(s[1]);

            
        }

        for(int i = 0; i < n - 1; i++)
        {
            if (h[i] == h[i + 1] && m[i] == m[i+1])
            {
                
               Count++;
            }
            else
            {
                Count = 1;
            }

            if (Count > maxcount)
            {
                maxcount = Count;
            }


        }
        Console.WriteLine(maxcount);

        
    }
}