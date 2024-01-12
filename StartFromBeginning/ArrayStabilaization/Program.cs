public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] S = Console.ReadLine().Split();


        int[] arr = Array.ConvertAll(S, int.Parse);

        Array.Sort(arr);    

        if (n == 2)
        {
            Console.WriteLine(0);
            return;
        }

        int result = Math.Min((arr[n - 1] - arr[1]), arr[n-2] - arr[0]);

        Console.WriteLine(result);




    }
}