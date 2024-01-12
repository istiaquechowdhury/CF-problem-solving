public class Program
{
    public static void Main()
    {
        int[] arr = { 250, 645, 300, 900, 50 };

        int[] finalNum = new int[5];

        for(int i = 0; i < arr.Length; i++)
        {
            int num = (arr[i] * 10) / 100;
            int number = arr[i] - num;

            Console.WriteLine(number);
        }
        
    }
}