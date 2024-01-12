public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

       
        string[] s = Console.ReadLine().Split();

        int[] arr  = new int[n];    

        for(int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(s[i]);
        }
        int Officers = 0;
        int UntreatedCrime = 0;

        for (int i = 0;i < n; i++)
        {
            if (arr[i]  < 0) 
            {
                if(Officers == 0)
                {
                    UntreatedCrime++;
                }
                else
                {
                    Officers--;
                }
            }
            else
            {
                Officers = Officers + arr[i];
            }
        }
        Console.WriteLine(UntreatedCrime);

            
        



    }
}