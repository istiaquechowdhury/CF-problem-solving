//public class Program
//{
//    public static void Main()
//    {
//        string[] S = Console.ReadLine().Trim('{', '}').Split(new[] {", "},StringSplitOptions.RemoveEmptyEntries) ;


//        int DistinctLetter = S.Distinct().Count() ;

//        Console.WriteLine(DistinctLetter);
//    }
//}

public class Program
{
    public static void Main()
    {
        string[] S = Console.ReadLine().Trim('{', '}').Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);


        HashSet<string> A = new HashSet<string>(S);

        


        Console.WriteLine(A.Count);

    }
}