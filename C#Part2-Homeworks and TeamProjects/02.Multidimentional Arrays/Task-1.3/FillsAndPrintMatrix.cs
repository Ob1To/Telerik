//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

namespace Task_1._3
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
            for (int row = firstMatrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int row2 = row, col = 0; row2 < firstMatrix.GetLength(0); row2++, col++)
                {
                    firstMatrix[row2, col] = element;
                    element++;
                }
            }

            for (int col = 1; col < firstMatrix.GetLength(1); col++)
            {
                for (int col2 = col, row = 0; col2 < firstMatrix.GetLength(1); col2++, row++)
                {
                    firstMatrix[row, col2] = element;
                    element++;
                }
            }

            for (int row = 0; row < firstMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < firstMatrix.GetLength(1); col++)
                {
                    Console.Write("{0}", firstMatrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
