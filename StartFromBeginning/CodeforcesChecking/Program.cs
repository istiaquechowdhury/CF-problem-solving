public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            char c = char.Parse(Console.ReadLine().ToLower());  

            if(c =='c' || c=='o' ||c == 'd' || c == 'e' ||c == 'f' || c == 'o' || c == 'r' || c == 'c'|| c == 'e' || c == 's')
            {
                Console.WriteLine("YES");

            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}