public class Program
{
    public static void Main()
    {
        int n = int.Parse( Console.ReadLine());

        int Result = 0;

        for(int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());

            string[] s = Console.ReadLine().Split();

            if (s[0] != s[1] && s[0] != s[2])
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int j = 1; j < x; j++)
                {
                    if (s[0] != s[j])
                    {

                        Console.WriteLine(j + 1);
                    }
                }
            }

            

        }

    }
}
//using System;

//namespace UniqueElementIndex
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int t = int.Parse(Console.ReadLine());

//            for (int k = 0; k < t; k++)
//            {
//                int n = int.Parse(Console.ReadLine());
//                string[] arr = Console.ReadLine().Split(' ');
//                int[] a = Array.ConvertAll(arr, int.Parse);

//                if (a[0] != a[1] && a[0] != a[2])
//                {
//                    Console.WriteLine(1);
//                }
//                else
//                {
//                    for (int i = 1; i < n; i++)
//                    {
//                        if (a[i] != a[0])
//                        {
//                            Console.WriteLine(i + 1);
//                            break;
//                        }
//                    }
//                }
//            }
//        }
//    }
//}



