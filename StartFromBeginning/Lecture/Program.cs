using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int ProfessorLecture = int.Parse(s[0]); 

        int LanguagesWord = int.Parse(s[1]);

        string[] wordsarray = new string[LanguagesWord * 2];

        int iterateCount = 0;   

        for(int i = 0; i < LanguagesWord; i++)
        {
            string[] words = Console.ReadLine().Split();


            wordsarray[i+iterateCount] = words[0];
            wordsarray[i + 1 + iterateCount] = words[1];  
            iterateCount++;
        }

        string[] ProfsWord = Console.ReadLine().Split();

        string[] PrintName = new string[ProfessorLecture];


        for(int i = 0; i < ProfessorLecture; i++)
        {
            for(int j = 0; j < wordsarray.Length; j++)
            {
                if (ProfsWord[i] == wordsarray[j])
                {
                    if (wordsarray[j].Length < wordsarray[j+1].Length)
                    {
                        PrintName[i] = wordsarray[j];
                    }
                    else if (wordsarray[j].Length == wordsarray[j+1].Length)
                    {
                        PrintName[i] = wordsarray[j];

                    }
                    else
                    {
                        PrintName[i] = wordsarray[j+1];
                    }
                    
                }
            }
        }
        
        for(int i = 0;i < ProfessorLecture;i++)
        {
            Console.WriteLine(PrintName[i]);
        }



        
        
        


       



    }
}