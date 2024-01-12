public class Program
{
    public static void Main()
    {
        string[] NH = Console.ReadLine().Split();


        int N = int.Parse(NH[0]);
        int H = int.Parse(NH[1]);
        int count = 0;
        

        string[] Numbers = Console.ReadLine().Split();

        for(int i = 0; i < N; i++)
        {
            int NUM = int.Parse(Numbers[i]);
            if(NUM <= H)
            {
                count++;
            }
            else if (NUM >= H)
            {
                count = count + 2;
            }
        }
        Console.WriteLine(count);
       
    }
}