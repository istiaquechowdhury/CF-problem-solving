public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int Count = 0;

        for(int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();

            if(s == "Tetrahedron")
            {
                Count = Count + 4;     
            }
            else if( s == "Cube")
            {
                Count = Count + 6;
            }
            else if( s == "Octahedron")
            {
                Count = Count + 8;
            }
            else if(s == "Dodecahedron")
            {
                Count = Count + 12;
            }
            else if(s == "Icosahedron")
            {
                Count = Count + 20;
            }
            
        }
        Console.WriteLine(Count);

        
    }
}