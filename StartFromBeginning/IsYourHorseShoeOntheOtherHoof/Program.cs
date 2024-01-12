public class Program
{
    public static void Main()
    {

        string[] abcd = Console.ReadLine().Split();
        int[] arr = new int[abcd.Length];


        for (int i = 0; i < abcd.Length; i++)
        {
            arr[i] = int.Parse(abcd[i]);
        }

        int Count = 0;
        int CountforPrint = 0;

        for (int i = 1;i < abcd.Length; i++)
        {
            if (arr[i] == arr[i-1] )
            {
                Count++;
                
            }
        }

        Console.WriteLine(Count);
    }


}