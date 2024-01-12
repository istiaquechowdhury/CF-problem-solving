using System.ComponentModel.DataAnnotations;
using System.Text;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int abCount = 0;
        int baCount = 0;

        for (int i = 0; i < n; i++)
        {

            string s = Console.ReadLine();

            StringBuilder sb = new StringBuilder(s);



            for (int j = 0; j < s.Length - 1; j++)
            {
                string substring = s.Substring(j, 2);

                if (substring == "ab")
                {
                    abCount++;
                }
                else if (substring == "ba")
                {
                    baCount++;
                }
            }
            if (abCount == baCount)
            {
                Console.WriteLine(s);
            }
            else if (abCount > baCount)
            {
                for (int k = 0; k < s.Length; k++)
                {

                    if (s[k] == 'a')
                    {
                        s = s.Remove(k, 1).Insert(k, "b");
                        abCount--;
                        if (abCount == baCount)
                            break;
                    }

                }
                Console.WriteLine(s);
            }
            else
            {
                for (int k = 0; k < s.Length; k++)
                {
                    if (s[k] == 'b')
                    {
                        s = s.Remove(k, 1).Insert(k, "a");
                        baCount--;
                        if (abCount == baCount)
                            break;
                    }
                }
                Console.WriteLine(s);


            }
        }
    }
}

