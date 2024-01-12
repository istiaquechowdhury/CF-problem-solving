//public class Program
//{
//    public static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        int[] Home = new int[n];
//        int[] Away = new int[n];    

//        for(int i = 0; i < n; i++)
//        {
//            string[] Input = Console.ReadLine().Split();

//            Home[i] = int.Parse(Input[0]);
//            Away[i] = int.Parse(Input[1]);  
//        }

//        int Count = 0;

//        for(int i = 0; i < n; i++)
//        {
//            for (int j = 0; j < n; j++) 
//            {
//                if ( i != j && Home[i] == Away[j])
//                {
//                    Count++;
//                }
            
//            }
//        }
//        Console.WriteLine(Count);   
//    }
//}


public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine()); 
        
        int[] Home = new int[n];
        int[] Away = new int[n];

        for (int i = 0; i < n; i++)
        {
            string[] Numbers = Console.ReadLine().Split();

            Home[i] = int.Parse(Numbers[0]);
            Away[i] = int.Parse(Numbers[1]);
        }

        int count = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(i != j) 

                 if (Home[i] == Away[j])
                    count++;
                    
            }
        }
        Console.WriteLine(count);
    }

}