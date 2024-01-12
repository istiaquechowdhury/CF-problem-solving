public class Program
{
    public static void Main()
    {
        long Input = long.Parse( Console.ReadLine());

        int CountLuckyNumber = 0;


        foreach (char i in Input.ToString())
        {
            if (i == '4' || i == '7' )
            {
                CountLuckyNumber++;
            }
            
        }
        if ( CountLuckyNumber == 4 || CountLuckyNumber == 7 )
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}