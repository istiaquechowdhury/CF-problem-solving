public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());  
        
        for(int i = 0; i <n; i++)
        {
            string[] s = Console.ReadLine().Split();

            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);    
            int c = int.Parse(s[2]);
            int d = int.Parse(s[3]);

            int mx1 = Math.Max(a, b);
            int Mn1 = Math.Min(a, b);   
            int mx2 = Math.Max(c, d);
            int mn2 = Math.Min(c, d);

            if(Mn1>mx2 || mn2>mx1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}