//public class Program
//{
//    public static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());

//        int turn = 1;
//        int AlishaMove = 0;
//        int BobMove = 0;

//        for(int i = 0; i < n; i++)
//        {
//            string s = Console.ReadLine();  

//            for(int j = 1; j < s.Length; j++)
//            {
//               if (s[j] != s[j-1])
//               {
//                   if(turn % 2 != 0)
//                   {
//                        AlishaMove++;
//                        turn++;
//                   }
//                   else
//                   {
//                        BobMove++;
//                        turn++;

//                   }

//               }

//            }
//            if (AlishaMove > BobMove)
//            {
//                Console.WriteLine("DA");
//                AlishaMove = 0; BobMove = 0 ;
//            }
//            else
//            {
//                Console.WriteLine("NET");
//                AlishaMove = 0; BobMove = 0;
//            }

//        }

//    }
//}

using System;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string s = Console.ReadLine();

            // Count the number of 1's in the string
            int onesCount = 0;
            foreach (char c in s)
            {
                if (c == '1')
                {
                    onesCount++;
                }
            }

            // Alice wins if the number of 1's is odd
            if (onesCount % 2 == 1)
            {
                Console.WriteLine("DA"); // Alice can win
            }
            else
            {
                Console.WriteLine("NET"); // Alice cannot win
            }
        }
    }
}


