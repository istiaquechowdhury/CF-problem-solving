public class Program
{
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());  

        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine().ToLower();

            if(s == "yes")
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