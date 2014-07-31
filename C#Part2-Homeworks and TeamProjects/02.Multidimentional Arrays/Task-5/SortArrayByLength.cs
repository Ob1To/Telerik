/*You are given an array of strings. 
 * Write a method that sorts the array by the length of its elements (the number of characters composing them).
*/

namespace Task_5
{
    using System;
    using System.Collections.Generic;
    class SortArrayByLength
    {
        static void Main()
        {
            string[] stringArray = { "op", "opop", "popopopo", "alabala", "portokalatatata" };
            int theLength = stringArray.Length;
            Console.WriteLine(theLength);
            int[] sizes = new int[theLength];

            for (int i = 0; i < theLength; i++)
            {
                sizes[i] = stringArray[i].Length;
            }
            Array.Sort(sizes, stringArray);
            foreach (var element in stringArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
