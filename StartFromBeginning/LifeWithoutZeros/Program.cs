public class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());  

        int b = int.Parse(Console.ReadLine());

        int Result = a + b;

        int [] arr = TointegerArray(a);

        int[] arr2 = TointegerArray(b);

        int[] Resultarr = TointegerArray(Result);


        int [] NonZeroArray =  RemoveZero(arr);

        int [] NonZeroArray2 = RemoveZero(arr2);   

        int [] NonZeroResultarr = RemoveZero(Resultarr);


        int Numbera = ArrayTOinteger(NonZeroArray);

        int Numberb = ArrayTOinteger(NonZeroArray2);

        int NumberResult = ArrayTOinteger(NonZeroResultarr);

        int Finalresult = Numbera + Numberb;
        
        if(Finalresult == NumberResult)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
        



       
    }

    public static int[] TointegerArray(int a)
    {
        string number = a.ToString();  
        
        int[] arr = new int[number.Length];

        for(int i  = 0; i < number.Length; i++)
        {
            arr[i] = int.Parse(number[i].ToString());
        }

        return arr; 
    }

    public static int[] RemoveZero(int[] arr)
    {
        int Count = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                Count++;
            }
        }

        int[] ArrayDigit = new int[arr.Length - Count];

        int Index = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                ArrayDigit[Index] = arr[i];
                Index++;   
            }
        }
        return ArrayDigit;  
    }
    public static int ArrayTOinteger(int[] arr)
    {
       string join =  string.Join("", arr);

       int Number = int.Parse(join);

       return Number; 

    }
}