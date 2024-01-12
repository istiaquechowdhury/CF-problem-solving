public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] Mishka = new int[n];
        int[] Chris = new int[n]; 
        
        int MishkaCount= 0;
        int ChrisCount= 0;  

        for(int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split();

            Mishka[i] = int.Parse(s[0]);
            Chris[i] = int.Parse(s[1]); 

        }

        for(int i = 0; i < n;i++)
        {
            if (Mishka[i] > (Chris[i])) 
            {
                MishkaCount++;
            }
            else if (Mishka[i] < (Chris[i]))
            {
                ChrisCount++;   
            }
            
        }
        if(MishkaCount > ChrisCount) 
        {
            Console.WriteLine("Mishka");
        }
        else if(MishkaCount < ChrisCount) 
        {
            Console.WriteLine("Chris");
        }
        else
        {
            Console.WriteLine("Friendship is magic!^^");
        }
    }
}