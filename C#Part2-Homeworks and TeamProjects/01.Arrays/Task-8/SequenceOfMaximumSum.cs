using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?
 * */


namespace Task_8
{
    class SequenceOfMaximumSum
    {
        static void Main()
        {
            Console.WriteLine("Please enter how much elements your array will have: ");
            int numberOfElements = int.Parse(Console.ReadLine());

            int[] kadansAlgorithm = new int[numberOfElements];
            Console.WriteLine("Please enter values for your elements");

            for (int i = 0; i < kadansAlgorithm.Length; i++)
            {
                Console.Write("{0}: ", i);
                kadansAlgorithm[i] = int.Parse(Console.ReadLine());
            }
            int maxSofar = kadansAlgorithm[0];
            int maxEndHere = kadansAlgorithm[0];
            int begin = 0;
            int beginTemp = 0;
            int end = 0;
            for (int i = 1; i < numberOfElements; i++)
            {
                maxEndHere = maxEndHere + kadansAlgorithm[i];
                if (kadansAlgorithm[i] > maxEndHere)
                {
                    maxEndHere = kadansAlgorithm[i];
                    beginTemp = i;
                }
                if (maxEndHere > maxSofar)
                {
                    maxSofar = maxEndHere;
                    begin = beginTemp;
                    end = i;
                }
            }
            Console.WriteLine("Your maximum sequence is: ");
            for (int i = begin; i <= end; i++)
            {
                Console.Write("{0} ", kadansAlgorithm[i]);
            }
            Console.WriteLine();
        }
    }
}
