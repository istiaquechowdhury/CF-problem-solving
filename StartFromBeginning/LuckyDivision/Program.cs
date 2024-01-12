public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string result = "";

        int LuckyDigit = 0;


        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                result =  i.ToString();

                if (result == "47" || result == "74" || result == "477" || result == "744" || result == "4" || result == "7" || result == "77"||result =="44")
                {
                    LuckyDigit++;
                }
            }

        }
        

      

        if (LuckyDigit >= 1)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }



    }
}
