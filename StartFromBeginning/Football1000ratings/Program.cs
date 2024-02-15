public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] s = new string[n];


        int MatchCount = 1;

        string AssignMatchCount = "";

        int NotMatchCount = 0;


        string AssignNotMatchCount = "";


        for (int i = 0; i < n; i++)
        {
            s[i] = Console.ReadLine();  
        }

        if(n == 1)
        {
            Console.WriteLine(s[0]);
        }

        for(int i = 0; i < n;i++)
        {

            for(int j = 0; j <= n-1; j++)
            {
                if (i != j)
                {
                    if (s[i] == s[j])
                    {

                       MatchCount++;
                       
                       AssignMatchCount = s[i];
                       

                    }
                    else
                    {
                        NotMatchCount++;
                        AssignNotMatchCount = s[j];
                    }
                }

            }
            if(MatchCount > NotMatchCount) 
            {
                Console.WriteLine(AssignMatchCount);
                break;
            }
            else if(MatchCount < NotMatchCount)
            {
                Console.WriteLine(AssignNotMatchCount);
                break;
            }
        }
      
    }
}