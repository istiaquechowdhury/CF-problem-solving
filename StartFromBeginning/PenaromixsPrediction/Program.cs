//using System;

//public class Program
//{
//    public static void Main()
//    {
//        string[] input = Console.ReadLine().Split();
//        int n = int.Parse(input[0]);
//        int m = int.Parse(input[1]);

//        if (IsPrime(m))
//        {
//            int nextPrime = FindNextPrime(n);
//            if (m == nextPrime)
//            {
//                Console.WriteLine("YES");
//            }
//            else
//            {
//                Console.WriteLine("NO");
//            }
//        }
//        else
//        {
//            Console.WriteLine("NO");
//        }
//    }

//    static bool IsPrime(int number)
//    {
//        if (number < 2) return false;
//        if (number == 2) return true;
//        if (number % 2 == 0) return false;
//        for (int i = 3; i <= Math.Sqrt(number); i += 2)
//        {
//            if (number % i == 0)
//            {
//                return false;
//            }
//        }
//        return true;
//    }

//    static int FindNextPrime(int n)
//    {
//        while (true)
//        {
//            n++;
//            if (IsPrime(n))
//            {
//                return n;
//            }
//        }
//    }
//}

using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        string[] S = Console.ReadLine().Split();

        int n = int.Parse(S[0]);
        
        int m = int.Parse(S[1]);

       if( IsPrime(m))
       {
           int NextPrime = Findnextnumber(n);
           if(m == NextPrime)
           {
                Console.WriteLine("YES");
           }
           else
           {
                Console.WriteLine("NO");

           }
       }
       else
       {
            Console.WriteLine("NO");
       }
       
    }

    public static bool IsPrime(int n)
    {
       if (n < 2)
        return false;
       if(n == 2) return true;
       if (n % 2 == 0) return false; 
       
       for(int i = 3; i <= Math.Sqrt(n); i++)
       {
            if (n % i == 0) return
                    false;

       }
       return true;

       

    }

    public static int Findnextnumber(int n)
    {
        while(true)
        {
            n++;
            if(IsPrime(n))
            {
                return n;
            }
        }
    }
}
