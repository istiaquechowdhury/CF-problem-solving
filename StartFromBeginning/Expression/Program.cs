public class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        int b = int.Parse(Console.ReadLine());

        int c = int.Parse(Console.ReadLine());

        int result1 = a + b + c;
        
        int result2 = a + b * c;

        int result3 = a * b + c;

        int result4 = a +(b + c);

        int result5 = (a + b) + c;

        int result6 = a + (b * c);

        int result7 = (a + b) * c;

        int result8 = a * (b + c);  

        int result9 = (a * b) + c;

        int result10 = a * b * c;

        int result11 = (a * b) * c;

        int result12 = a * (b * c);


       int max1 = Math.Max(Math.Max(result1, result2), Math.Max(result3, result4));

       int max2 = Math.Max(Math.Max(result5, result6), Math.Max(result7, result8));

       int max3 = Math.Max(Math.Max(result9, result10), Math.Max(result11, result12));


        int semifinalmax = Math.Max(max1, max2);

        int finalmax = Math.Max(semifinalmax, max3);


       

       Console.WriteLine(finalmax); 

        
    }
}