using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string s = Console.ReadLine();

        string substring = "";


        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();



        for (int i = 0; i < n - 1; i++)
        {
            substring = s.Substring(i, 2);

            if (keyValuePairs.ContainsKey(substring))
            {
                keyValuePairs[substring]++;
            }
            else
            {
                keyValuePairs[substring] = 1;
            }
        }

        int Count = 0;
        string finalstring = "";

        foreach (var  keyValuePair in keyValuePairs)
        {
           if(keyValuePair.Value > Count)
           {
                Count = keyValuePair.Value;
                finalstring = keyValuePair.Key;
           }
        }

        Console.WriteLine(finalstring);



    }
}