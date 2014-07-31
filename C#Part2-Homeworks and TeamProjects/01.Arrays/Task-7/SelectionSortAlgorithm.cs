/*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
 * Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
 * find the smallest from the rest, move it at the second position, etc.
 */

namespace Task_7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class SelectionSortAlgorithm
    {
        static void Main()
        {
            Console.WriteLine("Please enter how much elements your array will have: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] selectionSortArray = new int[arrayLength];
            Console.WriteLine("Please enter values for your elements");
            for (int i = 0; i < selectionSortArray.Length; i++)
            {
                Console.Write("{0}: ", i);
                selectionSortArray[i] = int.Parse(Console.ReadLine());
            }
            int temp = 0;
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    if (selectionSortArray[j] < selectionSortArray[i])
                    {
                        temp = selectionSortArray[j];
                        selectionSortArray[j] = selectionSortArray[i];
                        selectionSortArray[i] = temp;
                    }
                }
            }
        }
    }
}
