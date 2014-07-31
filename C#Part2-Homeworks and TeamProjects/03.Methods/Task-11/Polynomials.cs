//This solution is taken from the telerik forum because of its complexity and ... i couldn't understand it very well. As of this time i'm trying to understand it :)

using System;
using System.Collections.Generic;

namespace Task_11
{
    class Polynomials
    {
        static int lenghtofPolinomial = 0;
        static int[] polinomialCoef = new int[lenghtofPolinomial];
        static int[] result = new int[10];
        static int[] firstPolinomial = AddPolinomial();
        static int[] secondPolinomial = AddPolinomial();


        static int[] AddPolinomial()
        {
            Console.WriteLine("Enter lenght of polinomial:");
            lenghtofPolinomial = int.Parse(Console.ReadLine());
            polinomialCoef = new int[lenghtofPolinomial];

            for (int i = lenghtofPolinomial - 1; i >= 0; i--)
            {
                Console.Write("x^{0} =", i);
                polinomialCoef[i] = int.Parse(Console.ReadLine());
            }
            return polinomialCoef;
        }
        static int[] PrintPolinomialsCoeficients(int[] polinomialCoef)
        {
            for (int i = polinomialCoef.Length - 1; i >= 0; i--)
            {
                if (polinomialCoef[i] == 0)
                {
                    continue;
                }
                if (i == 0)
                {
                    Console.Write(polinomialCoef[i]);
                }
                else if (i == 1)
                {
                    Console.Write("{0} * x", polinomialCoef[i]);
                }
                else
                {
                    Console.Write("{0} * x^{1}", polinomialCoef[i], i);
                }
                if (i > 0)
                {
                    Console.Write(" + ");
                }
            }
            Console.WriteLine("\n");

            return polinomialCoef;
        }
        static int[] SumPolinomials(int[] polinomialCoef)
        {
            int minLength = Math.Min(firstPolinomial.Length, secondPolinomial.Length);
            int maxLength = Math.Max(firstPolinomial.Length, secondPolinomial.Length);
            result = new int[maxLength];

            for (int i = maxLength - 1; i >= 0; i--)
            {
                if (i < minLength)
                {
                    result[i] = firstPolinomial[i] + secondPolinomial[i];
                }
                else if (i > firstPolinomial.Length - 1)
                {
                    result[i] = secondPolinomial[i];
                }
                else if (i > secondPolinomial.Length - 1)
                {
                    result[i] = firstPolinomial[i];
                }
            }

            return result;
        }
        static int[] SubtractionPolinomials(int[] polinomialCoef)
        {
            int minLength = Math.Min(firstPolinomial.Length, secondPolinomial.Length);
            int maxLength = Math.Max(firstPolinomial.Length, secondPolinomial.Length);
            result = new int[maxLength];

            for (int i = maxLength - 1; i >= 0; i--)
            {
                if (i < minLength)
                {
                    result[i] = firstPolinomial[i] - secondPolinomial[i];
                }
                else if (i > firstPolinomial.Length - 1)
                {
                    result[i] = -secondPolinomial[i];
                }
                else if (i > secondPolinomial.Length - 1)
                {
                    result[i] = firstPolinomial[i];
                }
            }

            return result;
        }
        static int[] MultiplicationPolinomials(int[] polinomialCoef)
        {
            result = new int[firstPolinomial.Length + secondPolinomial.Length];

            for (int i = firstPolinomial.Length - 1; i >= 0; i--)
            {
                for (int j = secondPolinomial.Length - 1; j >= 0; j--)
                {
                    result[i + j] = firstPolinomial[i] * secondPolinomial[j];

                    if (result[i + j] == 0)
                    {
                        continue;
                    }
                    if (i + j == 0)
                    {
                        Console.Write(result[i + j]);
                    }
                    else if (i + j == 1)
                    {
                        Console.Write("{0} * x", result[i + j]);
                    }
                    else
                    {
                        Console.Write("{0} * x^{1} ", result[i + j], i + j);
                    }
                    if (i + j > 0)
                    {
                        Console.Write(" + ");
                    }
                }
            }
            Console.WriteLine();

            return result;
        }
        static void Main()
        {
            Console.WriteLine("\nFirst polinomial is:\n");
            PrintPolinomialsCoeficients(firstPolinomial);

            Console.WriteLine("\nSecond polinomial is:\n");
            PrintPolinomialsCoeficients(secondPolinomial);

            Console.WriteLine("\nSum of polinomials:\n");
            SumPolinomials(polinomialCoef);
            PrintPolinomialsCoeficients(result);

            Console.WriteLine("\nSubtraction of polinomials:\n");
            SubtractionPolinomials(polinomialCoef);
            PrintPolinomialsCoeficients(result);

            Console.WriteLine("\nMultiplication of polinomials:\n");
            MultiplicationPolinomials(polinomialCoef);

        }
    }
}
