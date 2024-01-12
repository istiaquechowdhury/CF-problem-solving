public class Program
{
    public static void Main()
    {
        int Input = int.Parse(Console.ReadLine());

        string Name = Console.ReadLine();

        int AntonCount = 0;
        int DanikCount = 0;

        for (int i = 0; i < Name.Length; i++)
        {
            if (Name[i] == 'A')
            {
                AntonCount++;
            }
            else
            {
                DanikCount ++;  
            }
        }

        if(AntonCount > DanikCount)
        {
            Console.WriteLine("Anton");
        }
        else if(AntonCount < DanikCount)
        {
            Console.WriteLine("Danik");
        }
        else
        {
            Console.WriteLine("Friendship");
        }
    }
}