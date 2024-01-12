public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());  

        for(int i = 0; i < n; i++)
        {
            string[] S = Console.ReadLine().Split();   

            int Number1 = int.Parse(S[0]);
            int Number2 = int.Parse(S[1]);
            int Number3 = int.Parse(S[2]);

            if(Number1 + Number2 == Number3 || Number1 + Number3 == Number2 || Number2 + Number3 == Number1)
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