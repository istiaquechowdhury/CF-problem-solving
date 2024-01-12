public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());  

        for(int i = 0; i < n; i++)
        {
            int l = int.Parse(Console.ReadLine());  

            string s = Console.ReadLine();



            if (l == 5 && (s[i] =='T'|| s[i] == 'i'|| s[i] == 'm'|| s[i] == 'u'|| s[i] == 'r' ))
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