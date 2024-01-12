public class Program
{
    public static void Main()
    {
        string num = Console.ReadLine();

        int Count = 0;
        
        for(int i = 0; i < num.Length; i++)
        {
            if (string.IsNullOrEmpty(num))
            {
                continue;
            }
            else
            {
               Count++;
            }
        }
        Console.WriteLine(Count);
    }
}