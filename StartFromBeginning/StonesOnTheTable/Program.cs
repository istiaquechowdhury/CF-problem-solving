public class Program
{
    public static void Main()
    { 
        int NumberOfStones = int.Parse(Console.ReadLine());

        string ColorOfStones = Console.ReadLine();  

        int Count = 0;

        for (int i = 1; i < NumberOfStones; i++)
        {
            if (ColorOfStones[i] == ColorOfStones[i-1])
            {
                Count++;
            }
        }
        Console.WriteLine(Count);
        //int n = int.Parse(Console.ReadLine());
        //string s = Console.ReadLine();
        //int count = 0;

        //for (int i = 1; i < n; i++)
        //{
        //    if (s[i] == s[i - 1])
        //    {
        //        count++;
        //    }
        //}

        //Console.WriteLine(count);


    }
}