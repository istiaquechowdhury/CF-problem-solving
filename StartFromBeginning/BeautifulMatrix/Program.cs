public class Program
{
    public static void Main()
    {
        int move = 0;
        for (int i = 0; i < 5; i++)
        {
            string[] s = Console.ReadLine().Split();

            for (int j = 0; j < s.Length; j++)
            {
                if (s[j] == "1")
                { 
                    move = Math.Abs(2-i) + Math.Abs(2-j);
                    break;


                }
            }
           
        }
        Console.WriteLine(move);
    }
}