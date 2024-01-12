public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());


        string input = Console.ReadLine().ToLower();

        HashSet<char> Letters = new HashSet<char>(input);

        foreach (char i in input)
        {
            if (char.IsLetter(i))
                Letters.Add(i);
        }

        if (Letters.Count == 26)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }


    }
}


