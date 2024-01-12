public class Program
{
    public static void Main()
    {
        
        int UserInput = int.Parse(Console.ReadLine());
        int CountHard = 0;
        int CountEasy = 0;
        string[] input = Console.ReadLine().Split();


        for (int i = 0; i < UserInput; i++)
        {

            
            int p = int.Parse(input[0]);

            


            if (p >= 1)
            {
                CountHard++;
            }
            else
            {
                CountEasy++;
            }
        }

        if (CountHard > 0)
        {
            Console.WriteLine("Hard");
        }
        else
        {
            Console.WriteLine("Easy");
        }
    }
}