//Write a program to convert hexadecimal numbers to binary numbers (directly).


namespace Task_5
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class HexaToBinaryDirectly
    {
        static string Convertor(string numberInHexadecimal)
        {
            numberInHexadecimal = numberInHexadecimal.ToUpper();
            StringBuilder binaryNumber = new StringBuilder();
            for (int i = 0; i < numberInHexadecimal.Length; i++)
            {
                switch (numberInHexadecimal[i])
                {
                    case 'A': binaryNumber.Append("1010"); break;
                    case 'B': binaryNumber.Append("1011"); break;
                    case 'C': binaryNumber.Append("1100"); break;
                    case 'D': binaryNumber.Append("1101"); break;
                    case 'E': binaryNumber.Append("1110"); break;
                    case 'F': binaryNumber.Append("1111"); break;
                    case '0': binaryNumber.Append("0000"); break;
                    case '1': binaryNumber.Append("0001"); break;
                    case '2': binaryNumber.Append("0010"); break;
                    case '3': binaryNumber.Append("0011"); break;
                    case '4': binaryNumber.Append("0100"); break;
                    case '5': binaryNumber.Append("0101"); break;
                    case '6': binaryNumber.Append("0110"); break;
                    case '7': binaryNumber.Append("0111"); break;
                    case '8': binaryNumber.Append("1000"); break;
                    case '9': binaryNumber.Append("1001"); break;
                }
            }
            while (binaryNumber[0] == '0') //remove zeros in the beggining
            {
                binaryNumber.Remove(0, 1);
            }
            return binaryNumber.ToString();
        }
        static void Main()
        {
            Console.WriteLine("Please enter your hexadecimal number : ");
            string hexaNumber = Console.ReadLine();
            Console.WriteLine("Your number in binary is : {0}",Convertor(hexaNumber));
        }
    }
}
