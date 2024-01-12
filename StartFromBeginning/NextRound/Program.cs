public class Program
{
    public static void Main()
    {
        int count = 0;
        string[] nk = Console.ReadLine().Split();

        int n =int.Parse(nk[0]);
        int k = int.Parse(nk[1]);


        string[] ParticipantsScore = Console.ReadLine().Split();

        int[] Participants = new int[n];

        
        for ( int i = 0; i < n; i++ )
        {
            Participants[i] = int.Parse(ParticipantsScore[i]);

        }

        int KthPosition = Participants[k - 1];

        for ( int j = 0; j < n; j++ )
        {
            if(Participants[j] >= KthPosition && Participants[j] > 0 )
            {
                count++;
            }
        }
        Console.WriteLine(count);
        



        
    }
}