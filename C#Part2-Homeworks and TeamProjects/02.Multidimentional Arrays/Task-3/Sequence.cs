/*
 * We are given a matrix of strings of size N x M. 
 * Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. 
 * Write a program that finds the longest sequence of equal strings in the matrix.
 */

namespace Task_3
{
    using System;
    class Sequence
    {
        static void Main()
        {
            string[,] matrix =
            {
                {"ha","fifi","ho","hi"},
                {"fo","ha","hi","xx"},
                {"xxx","ho","ha","xx"}
            };
            int currentSeq = 1;
            int maxSeq = 1;
            string maxElement = "";
            int direction = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row,col] == matrix[row,col + 1])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }
                    if (maxSeq < currentSeq)
                    {
                        maxSeq = currentSeq;
                        maxElement = matrix[row, col];
                        direction = 1;
                    }
                }
                currentSeq = 1;
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row,col] == matrix[row + 1,col])
                    {
                        currentSeq++;
                    }
                    else
                    {
                        currentSeq = 1;
                    }
                    if (maxSeq < currentSeq)
                    {
                        maxSeq = currentSeq;
                        maxElement = matrix[row, col];
                        direction = 2;
                    }
                }
                currentSeq = 1;
            }
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    for (int row = i, col = j; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1;row++, col++)
                    {
                        if (matrix[row,col] == matrix[row + 1, col + 1])
                        {
                            currentSeq++;
                        }
                        else
                        {
                            currentSeq = 1;
                        }
                        if (maxSeq < currentSeq)
                        {
                            maxSeq = currentSeq;
                            maxElement = matrix[row, col];
                            direction = 3;
                        }
                    }
                    currentSeq = 1;
                }
            }
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    for (int row = i, col = j; row < matrix.GetLength(0) - 1 && col > 0; row++, col--)
                    {
                        if (matrix[row, col] == matrix[row + 1, col - 1])
                        {
                            currentSeq++;
                        }
                        else
                        {
                            currentSeq = 1;
                        }

                        if (maxSeq < currentSeq)
                        {
                            maxSeq = currentSeq;
                            maxElement = matrix[row, col];
                            direction = 4;
                        }
                    }
                    currentSeq = 1;
                }
            }
            switch (direction)
            {
                case 1:
                    Console.WriteLine("Element \"{0}\" repeats {1} times horizontally.", maxElement, maxSeq);
                    break;
                case 2:
                    Console.WriteLine("Element \"{0}\" repeats {1} times vertically.", maxElement, maxSeq);
                    break;
                case 3:
                    Console.WriteLine("Element \"{0}\" repeats {1} times diagonally from top left to bottom right.", maxElement, maxSeq);
                    break;
                case 4:
                    Console.WriteLine("Element \"{0}\" repeats {1} times diagonally from top right to bottom left.", maxElement, maxSeq);
                    break;
                default:
                    Console.WriteLine("No repetitions of elements.");
                    break;
            }
        }
    }
}
