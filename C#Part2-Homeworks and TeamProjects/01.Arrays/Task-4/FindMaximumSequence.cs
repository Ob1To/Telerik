using System;
/*Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.*/


namespace Task_4
{
    class FindMaximumSequence
    {
        static void Main()
        {
            Console.WriteLine("Please enter the number of elements that your array will have");
            int numberElements = int.Parse(Console.ReadLine());

            int[] array = new int[numberElements];

            Console.WriteLine("Now please enter the values for the different positions");

            for (int i = 0; i < numberElements; i++)
            {
                Console.Write("For position {0}: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int tempNumber = array[0];
            int longestSequence = 1;
            int tempSequence = 0;
            int bestNumber = 0;

            for (int i = 0; i < numberElements; i++)
            {
                if (array[i] == tempNumber)
                {
                    tempSequence++;
                    tempNumber = array[i];
                }
                else
                {
                    tempSequence = 1;
                    tempNumber = array[i];
                }
                if (tempSequence >= longestSequence)
                {
                    longestSequence = tempSequence;
                    bestNumber = array[i];
                }
            }
            Console.Write("Your longest sequence is: ");
            for (int i = 0; i < longestSequence; i++)
			{
                Console.Write("{0} ", bestNumber);
			}
        }
    }
}
