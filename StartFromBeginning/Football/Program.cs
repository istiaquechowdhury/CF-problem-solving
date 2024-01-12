//public class Program
//{
//    public static void Main()
//    {
//        string Input = Console.ReadLine();

//        int CountConsecutive = 1;

//        for (int i = 1; i < Input.Length; i++)
//        {
//            if (Input[i] == Input[i-1])
//            {
//                CountConsecutive++;
//                if(CountConsecutive >= 7)
//                {
//                    Console.WriteLine("YES");
//                    return;

//                }
//            }
//            else
//            {
//                CountConsecutive = 1;
//            }
//        }
//        Console.WriteLine("NO");
//    }
//}

public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();

        int Count = 1;

        for(int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i-1])
            {
                Count++;
                if (Count >= 7)
                {
                    Console.WriteLine("YES");
                    return;
                }
                
            }
            else
            {
                Count = 1;
            }
            
        }
        Console.WriteLine("NO");
    }
}