using System;

//Write a program that compares two char arrays lexicographically (letter by letter).


namespace Task_3
{
    class CompareTwoCharArrays
    {
        static void Main()
        {
            Console.WriteLine("Please enter the chars for your first array: ");
            string firstChars = Console.ReadLine();
            Console.WriteLine("Please enter the chars for your second array: ");
            string secondChars = Console.ReadLine();

            char[] array1 = firstChars.ToCharArray();
            char[] array2 = secondChars.ToCharArray();

            int minLength = Math.Min(array1.Length, array2.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (array1[i] == array2[i])
                {
                    continue;
                }
                else
                {
                    if (array1[i] > array2[i])
                    {
                        Console.WriteLine("The first array is smaller then the second array lexicographically and comes first");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("The second array is smaller then the first array lexicographically and comes first");
                        return;
                    }
                }
            }
            if (array1.Length == array2.Length)
            {
                Console.WriteLine("The two arrays are equal");
            }
            else if (array1.Length > array2.Length)
            {
                Console.WriteLine("The first array is smaller then the second array lexicographically and comes first");
            }
            else
            {
                Console.WriteLine("The second array is smaller then the first array lexicographically and comes first");
            }
            /*In lexicographic order the elements are compared one by one starting from the very left. 
             * If the elements are not the same, the array, whose element is smaller (comes earlier in the alphabet), comes first. 
             * If the elements are equal, the next character is compared. 
             * If the end of one of the arrays is reached, without finding different elements, the shorter array is the smaller (comes earlier lexicographically). 
             * If all elements are equal, the arrays are equal.*/
        }
    }
}
