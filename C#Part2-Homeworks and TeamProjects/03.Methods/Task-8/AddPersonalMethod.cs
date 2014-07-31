/*
 * Write a method that adds two positive integer numbers represented as arrays of digits 
 * (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
 * Each of the numbers that will be added could have up to 10 000 digits.
*/

using System;
using System.Collections.Generic;

class Program
{
    static List<int> CalculateNumbers(List<int> number1, List<int> number2)
    {
        int difference = number1.Count - number2.Count;
        if (difference < 0)
        {
            difference = difference * -1;
        }
        if (number1.Count > number2.Count)
        {
            for (int i = 0; i < difference; i++)
            {
                number2.Add(0);
            }
        }
        else if (number1.Count < number2.Count)
        {
            for (int i = 0; i < difference; i++)
            {
                number1.Add(0);
            }
        }
        List<int> result = new List<int>();
        for (int i = 0; i < number1.Count + 1; i++)
        {
            result.Add(0);

        }
        for (int i = 0; i < number1.Count; i++)
        {
            result[i] = result[i] + number1[i] + number2[i];
            if (result[i] > 9)
            {
                result[i] = result[i] % 10;
                result[i + 1]++;
            }
        }
        if (result[result.Count - 1] == 0)
        {
            result.RemoveAt(result.Count - 1);
        }
        result.Reverse();
        return result;
    }
    static List<int> NumberAsArray (string numberAsString)
    {
        List<int> array = new List<int>();
        for (int i = 0; i < numberAsString.Length; i++)
        {
            array.Add(numberAsString[numberAsString.Length - 1 - i] - '0');
        }
        return array;
    }
    static void PrintList(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i]);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("Please enter the first number: ");
        string temp1 = Console.ReadLine();
        List<int> firstNumber = NumberAsArray(temp1);
        Console.WriteLine("Please enter the second number: ");
        string temp2 = Console.ReadLine();
        List<int> secondNumnber = NumberAsArray(temp2);
        List<int> result = CalculateNumbers(firstNumber, secondNumnber);
        PrintList(result);
    }
}