using System;

namespace PyramidBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int height = 0;
            int currentCubes = 0;

            while (currentCubes <= n)
            {
                height++;
                currentCubes += height * (height + 1) / 2;
                if (currentCubes > n)
                {
                    height--;
                    break;
                }
            }

            Console.WriteLine(height);
        }
    }
}
