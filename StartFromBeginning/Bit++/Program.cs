using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int X = 0;
        for (int i = 0; i < n; i++) 
        {
           string S = Console.ReadLine();

           if (S == "++X" || S == "X++")
           {
                X++;
           }

          else if(S =="--X" ||  S == "X--")
          {
                X--;

          }

        } 
        Console.WriteLine(X);
        
    }
}