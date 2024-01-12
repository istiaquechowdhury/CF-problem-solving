//public class Program
//{
//    public static void Main()
//    {



//        string S = Console.ReadLine();

//        string T = Console.ReadLine();

//        int Slength = S.Length;

//        int Tlength = T.Length;

//        int SmallerLengthString = Math.Min(Slength, Tlength);

//        int Count = 0;

//        int SsubstringCount = 0;

//        int TsubstringCount = 0;

//        int SubstringLength = S.Length - T.Length;

//        int SubstringLength2 = T.Length - S.Length;

//        int Result = 0;


//        if (SmallerLengthString == S.Length)
//        {
//            for (int i = 0; i < SmallerLengthString; i++)
//            {
//                string substring = T.Substring(SubstringLength2);

//                string substring2 = S.Substring(SsubstringCount);

//                if (substring == substring2)
//                {
//                    Result = Math.Abs(S.Length - T.Length) + Count;

//                }
//                else
//                {
//                    Count = Count + 2;
//                    SubstringLength2++;
//                    SsubstringCount++;
//                }
//            }
//            if (Result == 0)
//            {
//                int result2 = 0;

//                result2 = (S.Length - T.Length) + Count;
//                Console.WriteLine(result2);
//            }
//            else
//            {
//                Console.WriteLine(Result);
//            }

//        }

//        else if (SmallerLengthString == T.Length)
//        {
//            for (int i = 0; i < SmallerLengthString; i++)
//            {
//                string Ssubstring = S.Substring(SubstringLength);

//                string Tsubstring = T.Substring(TsubstringCount);

//                if (Tsubstring == Ssubstring)
//                {

//                    Result = Math.Abs(S.Length - T.Length) + Count;

//                }
//                else
//                {
//                    Count = Count + 2;
//                    SubstringLength++;
//                    TsubstringCount++;
//                }
//            }

//            if (Result == 0)
//            {
//                int result2 = 0;

//                result2 = (S.Length - T.Length) + Count;
//                Console.WriteLine(result2);
//            }
//            else
//            {
//                Console.WriteLine(Result);
//            }
//        }

//    }
//}


//public class Program
//{
//    public static void Main()
//    {
//        string S = Console.ReadLine();

//        string T = Console.ReadLine();

//        int Count = 0;



//        char[] Sarray = S.ToCharArray();

//        char[] Tarray = T.ToCharArray();

//        Array.Reverse(Sarray);

//        Array.Reverse(Tarray);

//        int Minlength = Math.Min(Sarray.Length,Tarray.Length);

//        int Maxlength = Math.Max(Sarray.Length, Tarray.Length);


//        for(int i = 0; i < Minlength; i++)
//        {
//            if (Sarray[i] == Tarray[i])
//                continue;

//            else
//            {
//                Count = Count + 2;
//            }


//        }

//        int ResultLength = Maxlength - Minlength;

//        Console.WriteLine(ResultLength + Count);





//    }
//}

public class Program
{
    public static void Main()
    {
        string S = Console.ReadLine();  
       
        string T = Console.ReadLine();

        int Slength = S.Length - 1;

        int Tlength = T.Length - 1;

        int Count = 0;


        while (Slength >= 0 && Tlength >= 0 && S[Slength] == T[Tlength]) 
        {
            Slength--;
            Tlength--;
            Count++;

        }

        int DeleteSlength = S.Length - Count;

        int DeleteTlength = T.Length - Count;   

        int Add = DeleteSlength + DeleteTlength;

        Console.WriteLine(Add); 
    }
}