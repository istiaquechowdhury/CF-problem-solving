public class Program
{
    public static void Main()
    {
        
            string Num1 = Console.ReadLine();

            string Num2 = Console.ReadLine();

            string result = FindDifference(Num1, Num2);

            Console.WriteLine(result);
        


    }

    public static string FindDifference(string num1, string num2)
    {
        char[] Result = new char[num2.Length];

        for (int i = 0; i < num1.Length; i++)
        {
            if (num1[i] == num2[i])
            {
                Result[i] = '0';
            }
            else
            {
                Result[i] = '1';
            }

           
        

        }
        return new string (Result);
    }
}