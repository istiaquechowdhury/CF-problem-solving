public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());  

        for(int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split();

            int a = int.Parse(s[0]);    
            int b = int.Parse(s[1]);    
            int c = int.Parse(s[2]);    

            if (a + b == c)
            {
                Console.WriteLine("+");
            }
            else if(a - b == c)
            {
                Console.WriteLine("-");
            }
        }
    }
}