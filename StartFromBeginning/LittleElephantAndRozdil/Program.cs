public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] s = Console.ReadLine().Split();

        int[] arr = Array.ConvertAll(s,int.Parse);

        

        int minIndex = arr[0];

        int IndexCount = 0;

        int Count = 0;

      

        for (int i = 0; i < n - 1; i++)
        {
            if(minIndex >= arr[i + 1])
            {
                minIndex = arr[i + 1];

                IndexCount = i + 1;

                
                
            }
            

        }

       
        
            for (int i = 0; i < n ; i++)
            {
                if (minIndex == arr[i])
                {
                   
                    Count++;
                    

                }
            }

        if (Count > 1)
        {
            Console.WriteLine("Still Rozdil");

        }
        else
        {
            Console.WriteLine(IndexCount + 1);
        }




















    }
}