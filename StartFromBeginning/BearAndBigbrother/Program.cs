public class Program
{
    public static void Main()
    {
        
            string[] ab = Console.ReadLine().Split();

            int a = int.Parse(ab[0]);

            int b = int.Parse(ab[1]);

            int Years = 0;
            while (a <= b)
            {
                a = a * 3;
                b = b * 2;

                Years++;
            }

            Console.WriteLine(Years);
        
    }
}