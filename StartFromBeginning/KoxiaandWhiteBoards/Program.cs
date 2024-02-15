public class Program
{

    public static void Main()
    {
        int l = int.Parse(Console.ReadLine());

        long add = 0;

        for(int i = 0; i < l; i++)
        {
            string[] nm = Console.ReadLine().Split();

            int n = int.Parse(nm[0]);   

            int m = int.Parse(nm[1]);


            string[] ni = Console.ReadLine().Split();

            string[] mi = Console.ReadLine().Split();


            int[] niarr = Array.ConvertAll(ni, int.Parse);

            int[] miarr = Array.ConvertAll(mi, int.Parse); 
            
            Array.Sort(niarr);  
            Array.Sort(miarr);

            int k = 1;
            int P = 1;

            for(int j = 0; j < niarr.Length; j++,P++)
            {
                
                if(miarr.Length > j)
                {
                    if (miarr[miarr.Length - k]> niarr[niarr.Length-P] || m <=1)
                    {
                        
                        
                            add = add + miarr[miarr.Length - k];
                            k++;
                        
                       
                    }
                    else
                    {
                        add = add + niarr[niarr.Length-P];
                    }
                    
                }
                else
                {
                    add = add + niarr[j];
                }
               
            }

            Console.WriteLine(add);
            add = 0;

            

        }
    }

}