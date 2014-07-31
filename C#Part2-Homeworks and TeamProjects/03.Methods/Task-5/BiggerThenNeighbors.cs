/*Write a method that checks if the element at given position in 
 * given array of integers is bigger than its two neighbors (when such exist).
*/

namespace Task_5
{
    using System;
    using System.Collections.Generic;
    public class BiggerThenNeighbors
    {
        public static bool IsBigger(int[] array, int number)
        {
            if (array[number] > (array[number + 1]) + (array[number - 1]))
            {
                return true;
            }
            return false;
        }

        static void Main()
        {
            Console.WriteLine("Please number of elements for your array: ");
            int numberElements = int.Parse(Console.ReadLine());
            int[] array = new int[numberElements];
            Console.WriteLine("Now enter values for your elements: ");
            for (int i = 0; i < numberElements; i++)
            {
                Console.Write("Element {0}: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the element number you want to check: ");
            int element = int.Parse(Console.ReadLine());
            while (element == 0 || element == numberElements - 1)  //Cover the corner cases where our element is equal to the first or last element .
            {
                Console.WriteLine("Please do not enter first or last element because it has only 1 neighbor");
                element = int.Parse(Console.ReadLine());
            }
            bool bigger = (IsBigger(array,element));
            if (bigger)
            {
                Console.WriteLine("It is bigger than its two neighbors");
            }
            else
            {
                Console.WriteLine("It is not bigger than its two neighbors");
            }
        }
    }
}
