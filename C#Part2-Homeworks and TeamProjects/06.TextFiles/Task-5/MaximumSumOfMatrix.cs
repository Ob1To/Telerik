/* Write a program that reads a text file containing a square matrix of numbers and 
 * finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. 
 * The first line in the input file contains the size of matrix N. 
 * Each of the next N lines contain N numbers separated by space. 
 * The output should be a single number in a separate text file. 
 * Example:
4
2 3 3 4
0 2 3 4			17
3 7 1 2
4 3 3 2
 */

namespace Task_5 //This solution is inspired by jasssonpet
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    class MaximumSumOfMatrix
    {
        static int FindMaximumSum(int[,] matrix)
        {
            int maxSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    maxSum = Math.Max(maxSum, matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1]);
                }
            }
            return maxSum;
        }
        static int[,] CreatingTheMatrix()
        {
            StreamReader reader = new StreamReader(@"..\..\..\files\Matrix.txt");
            int matrixSize = int.Parse(reader.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                string[] numbers = reader.ReadLine().Split(' '); //Gets line of numbers and by using split method takes only the numbers ignoring the spaces
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = int.Parse(numbers[j]);
                }

            }
            return matrix;

        }
        static void WriteResult(int MaximumSum)
        {
            StreamWriter writer = new StreamWriter(@"..\..\..\files\maxSumOutput.txt");
            using (writer)
            {
                writer.WriteLine(MaximumSum);
            }
        }
        static void Main()
        {
            WriteResult(FindMaximumSum(CreatingTheMatrix()));
            StreamReader reader = new StreamReader(@"..\..\..\files\maxSumOutput.txt");
            Console.Write("Your maximum sum read from the newely created text file is: ");
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
