

namespace Task_2
{
    using System;

    //Write a program that reads two arrays from the console and compares them element by element.
    class ReadAndCompare
    {
        static void Main()
        {
            Console.WriteLine("Please enter the length of the first array: ");
            int firstArrayLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the length of the second array: ");
            int secondArrayLength = int.Parse(Console.ReadLine());

            while (firstArrayLength != secondArrayLength) //looping while the user enters arrays with the same length so we can compare its elements 1 by 1.
            {
                Console.WriteLine("The two arrays cannot be comapred because they have different length. Please try with same length");
                Console.WriteLine("Please enter the length of the first array: ");
                firstArrayLength = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the length of the second array: ");
                secondArrayLength = int.Parse(Console.ReadLine());
            }
            int[] array1 = new int[firstArrayLength];
            int[] array2 = new int[secondArrayLength];

            Console.WriteLine("Please enter values for the elements of the first array: ");

            for (int i = 0; i < firstArrayLength; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please enter values for the elements of the second array: ");

            for (int i = 0; i < secondArrayLength; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            bool areEqual = true;

            for (int i = 0; i < firstArrayLength; i++) //it does not matter which array length we are using because they have equal length.
            {
                if (array1[i] != array2[i])
                {
                    areEqual = false;
                    break;
                }
            }
            if (areEqual)
            {
                Console.WriteLine("The elements of the arrays are equal !");
            }
            else
            {
                Console.WriteLine("The elements of the arrays are not equal !");
            }
        }
    }
}
