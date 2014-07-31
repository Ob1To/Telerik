/*Write a method that returns the index of the first element in array that is bigger than its neighbors, 
 *or -1, if there’s no such element.
 Use the method from the previous exercise.
*/

    using System;
    using System.Collections.Generic;
    class FirstBigger
    {
        static void GenerateRandom() //Create random matrix 
        {
            Random randomNumber = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = randomNumber.Next(50);
            }
        }
        static int[] myArray = new int[25];
        static void Main()
        {
            GenerateRandom(); //call the method for creating random matrix
            Console.WriteLine(string.Join(", ", myArray)); //printing the array
            for (int i = 1; i < myArray.Length - 1; i++) // we dont have to check zero element and last element because they dont have 2 neighbors
            {
                if (Task_5.BiggerThenNeighbors.IsBigger(myArray, i)) //calling the method from Task-5 as we should do according to the condition of the exercise
                {
                    Console.WriteLine("The Index of the first element in array that is bigger than its neighbors is: {0}", i);
                    return;
                }
            }
            Console.WriteLine("There is no such element");
        }
    }

