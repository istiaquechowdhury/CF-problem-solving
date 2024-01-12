public class Program
{
    public static void Main()
    {
        int pi = 1;
        int pj = 1;
        int pk = 1;

        int n = int.Parse(Console.ReadLine());  

        for(int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());  

            
                string[] s  =  Console.ReadLine().Split();

                int[] arr =  Array.ConvertAll(s,int.Parse);

            for (int k = 0; k < x - 1; k++)
            {
                if (arr[k] < arr[k + 1] && arr[k + 1] > arr[k + 2])
                {
                    pi = pi + k;
                    pj =  pj + k + 1;
                    pk = pk + k + 2;


                    Console.WriteLine("YES");
                    Console.Write($"{pi} {pj} {pk}");
                    Console.WriteLine();

                    pi = 1;
                    pj = 1 ;
                    pk = 1 ;
                    break;



                }
                else
                {
                    if(k + 2 ==  x - 1)
                    {
                        Console.WriteLine("NO");
                        break;
                    }
                }
            }
                        

                




        }
    }
}