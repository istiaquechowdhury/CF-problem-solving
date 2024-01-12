public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());  

        for(int i = 0; i < n; i++)
        {
            int Rating = int.Parse(Console.ReadLine()); 

            if (Rating >= 1900)
            {
                Console.WriteLine("Division 1");
            }
            else if(Rating >= 1600 && Rating <= 1899)
            {
                Console.WriteLine("Division 2");
            }
            else if(Rating >= 1400 && Rating <=1599)
            {
                Console.WriteLine("Division 3");
            }
            else if(Rating <= 1399)
            {
                Console.WriteLine("Division 4");
            }
        }
    }
}