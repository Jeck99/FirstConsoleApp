using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numsArrayWithSize = new int[4, 6];
            int[,] numsArray = new int[,] {
                { 8, 4, 7 },
                { 4, 7, 3 },
                { 3, 55, 8},
                { 0, 6, 8}
            };
            for (int i = 0; i < numsArray.GetLength(0); i++)
            {
                Console.Write($"|i: {i}=>");
                for (int j = 0; j < numsArray.GetLength(1); j++)
                {
                    Console.Write($"j: {j}|");
                }
                Console.WriteLine();
            }
            //numsArray[3, 7];
        }
    }
}
