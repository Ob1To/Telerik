//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)


namespace Homework_L2___Multidimentional_Arrays
{
    using System;
    class FillsAndPrintMatrix
    {
        static void Main()
        {
            Console.WriteLine("Please enter n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] firstMatrix = new int[n, n];
            int element = 1;
            for (int col = 0; col < firstMatrix.GetLength(1); col++)
            {
                for (int row = 0; row < firstMatrix.GetLength(0); row++)
                {
                    firstMatrix[row, col] = element;
                    element++;
                }
            }
            for (int row = 0; row < firstMatrix.GetLength(1); row++)
            {
                for (int col = 0; col < firstMatrix.GetLength(0); col++)
                {
                    Console.Write("{0} ", firstMatrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
