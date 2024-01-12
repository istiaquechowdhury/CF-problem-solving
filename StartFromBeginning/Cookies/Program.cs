public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int add = 0;

        int Count = 0;


        string[] s = Console.ReadLine().Split();

        
           

            int[] arr = Array.ConvertAll(s, int.Parse);

            for(int j = 0 ; j < arr.Length ; j++)
            {
                add = add + arr[j];

                
            }

            if(add % 2 == 0 )
            {
                for(int k = 0; k < arr.Length; k++)
                {
                    if(arr[k] % 2 == 0 )
                    {
                        Count++;    
                    }
                }
                Console.WriteLine(Count);

               
            }
            else
            {
                for(int l = 0; l < arr.Length; l++)
                {
                    if (arr[l]  % 2 != 0 )
                    {
                        Count++;
                    }
                }
                Console.WriteLine(Count);
                
            }
        
    }
}
