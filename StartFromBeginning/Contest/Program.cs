public class Program
{
    public static void Main()
    {
        string[] abcd = Console.ReadLine().Split();

        int[] arr = Array.ConvertAll(abcd,int.Parse);

        int a = arr[0];
        int b = arr[1];
        int c = arr[2];
        int d = arr[3];

        int MishasPoint = Math.Max((3 * a) / 10, a - (a / 250) * c);
        int pointsVasya = Math.Max((3 * b) / 10, b - (b / 250) * d);

        if( MishasPoint > pointsVasya)
        {
            Console.WriteLine("Misha");
        }
        else if( MishasPoint < pointsVasya)
        {
            Console.WriteLine("Vasya");
        }
        else
        {
            Console.WriteLine("Tie");
        }

    }
}