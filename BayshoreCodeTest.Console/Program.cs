using System;
using BayshoreCodeTest.Core;

namespace BayshoreCodeTest.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a number to spiral around: ");
            string input = System.Console.ReadLine();
            int parsedInput = Int32.Parse(input);

            var result = SpiralFormatter.CalculateSpiral(parsedInput);

            System.Console.WriteLine();

            for (int row = 0; row < result.GetLength(1); row++)
            {
                for (int col = 0; col < result.GetLength(1); col++)
                {
                    if (result[row, col] <= parsedInput)
                        System.Console.Write(result[row, col] + "\t");
                }

                System.Console.WriteLine();
            }

            System.Console.WriteLine();
        }       
    }
}