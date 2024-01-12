using System.Threading.Channels;

public class Program
{
    public static void Main()
    {
        string[] KNW = Console.ReadLine().Split();

        int k = int.Parse(KNW[0]);
        int n = int.Parse(KNW[1]);  
        int w = int.Parse(KNW[2]);

        int result = 0;
        int sum = 0;

        for (int i = 0; i < w ; i++) 
        {

             result = k * (i + 1);
             sum = sum + result;
            
        }
       int final = sum - n;
        
        Console.WriteLine(final);
    }
}