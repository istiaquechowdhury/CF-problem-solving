public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();

        string t = Console.ReadLine();  

        string Reverse = new string(s.Reverse().ToArray());

           if(Reverse == t)
           {
                Console.WriteLine("YES");
           }
           else
           {
                Console.WriteLine("NO");
           }
        

    }
}