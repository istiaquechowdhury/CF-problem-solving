//public class Program
//{
//    public static void Main()
//    {
//        string[] N = Console.ReadLine().Split();

//        int[] Numbers = new int[N.Length];  

//        for(int i  = 0; i < N.Length; i++)
//        {
//            Numbers[i] = int.Parse(N[i]);   
//        }

//        int max = Numbers[0];

//        for(int i = 1; i < Numbers.Length; i++) 
//        {
//            if (Numbers[i] > max)
//            {
//                max = Numbers[i];    
//            }
//        }
//        Console.WriteLine(max);

//    }
//}


public class Program
{
    public static void Main()
    {
        int Input = int.Parse(Console.ReadLine());

        int[] Numbers = new int[Input];


        for(int i = 0 ; i < Numbers.Length ; i++)
        {
            Numbers[i] = int.Parse(Console.ReadLine());
        }

        for( int i = 1 ;i < Numbers.Length ; i++)
        {
            if (Numbers[i] > Numbers[0])
            {
                Numbers[0] = Numbers[i];    
            }
        }
        Console.WriteLine(Numbers[0]);
    }
}