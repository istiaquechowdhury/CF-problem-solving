public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int BC = Bill(n);
        Console.WriteLine(BC);
    }

    public static int Bill(int n)
    {
        int BillCount = 0;

        while(n >= 100)
        {
            n = n - 100;
            BillCount++;
            
        }
        while (n >= 20)
        {
            n = n - 20;
            BillCount++;
        }
        while (n >= 10)
        {
            n = n - 10;
            BillCount++;

        }
        while (n >= 5)
        {
            n = n - 5;
            BillCount++;
        }

        while (n >= 1)
        {
            n = n - 1;
            BillCount++;
        }

        return BillCount;   


    }
}