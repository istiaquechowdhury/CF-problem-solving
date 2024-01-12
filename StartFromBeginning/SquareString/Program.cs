public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());  

        for(int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();      

            if(s.Length % 2 != 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                string Firsthalf = s.Substring(0,s.Length/2);
                string SecondHalf = s.Substring(s.Length / 2);

                if (Firsthalf.Equals(SecondHalf))
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
}