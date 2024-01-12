using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        string first = Console.ReadLine().ToUpper();  

        string second = Console.ReadLine().ToUpper(); 

        if(first.CompareTo(second) == 0 )
        {
            Console.WriteLine("0");
        }

        else if(first.CompareTo(second) < 0 )
        {
            Console.WriteLine("-1");
        }
        else
        {
            Console.WriteLine("1");
        }
    }
}