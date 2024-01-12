
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string s = Console.ReadLine();

        string result = "";


        int i = 0;
        while (n > 0)
        {
            if (n % 2 == 0)
            {
                result = s[i] + result;
            }
            else
            {
                result = result + s[i];
            }
            i++;
            n--;





        }
        Console.WriteLine(result);
    }
}