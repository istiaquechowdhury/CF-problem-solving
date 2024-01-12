public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string s = Console.ReadLine().ToLower();

        HashSet<char> set = new HashSet<char>();


        foreach (char c in s)
        {
            set.Add(c);

        }

        if(set.Count == 26)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }

        
    }
}