public class Program
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();

        string A = Console.ReadLine();

        int add = 0;

        for(int i = 0; i < A.Length; i++)
        {
            if ((A[i]) == '1')
            {
                add = add + int.Parse(s[0]);
            }
            else if ((A[i] == '2'))
            {
                add = add + (int.Parse(s[1]));
            }
            else if ((A[i] == '3'))
            {
                add = add + (int.Parse(s[2]));
            }
            else if ((A[i] == '4'))
            {
                add = add + (int.Parse(s[3]));
            }




        }
        Console.WriteLine(add);
    }
}