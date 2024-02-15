public class Program
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int n = int.Parse(s[0]);    

        int m = int.Parse(s[1]);


        string[] arr = Console.ReadLine().Split();

        int[] array = Array.ConvertAll(arr, int.Parse);

        int result = 0;

        int Count = 0;

       

        while(IsnumberGreater(array, m))
        {
            for(int i = 0; i < n; i++)
            {
                if (array[i] > m)
                {
                    array[i] = array[i] - m;
                    result = i;
                    Count++;
                }
            }
        }

        




        

        if( Count == 0 )      
        {
            Console.WriteLine(n);
        }
        else
        {
            Console.WriteLine(result + 1);

        }



       


    }

    public static bool IsnumberGreater(int[] array,int m)
    {
        foreach(int i in array)
        {
            if(i > m)
            {
                return true;
            }
           
        }
        return false;
    }
}