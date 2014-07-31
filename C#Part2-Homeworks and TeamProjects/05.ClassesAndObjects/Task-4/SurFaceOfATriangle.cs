/*Write methods that calculate the surface of a triangle by given:
 *Side and an altitude to it; 
 *Three sides; 
 * Two sides and an angle between them. Use System.Math.
*/

namespace Task_4
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class SurFaceOfATriangle
    {
        static double ByTwoSidesAndAngle()
        {
            Console.WriteLine("Please enter two sides of your triangle and an angle: ");
            Console.Write("Side 1: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Side 2: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Angle: ");
            double angle = double.Parse(Console.ReadLine());
            angle = (Math.PI * angle) / 180;
            double area = (sideA * sideB) * Math.Sin(angle) / 2;
            return area;
        }
        static double ByThreeSides()
        {
            Console.WriteLine("Please enter the sides of your triangle");
            Console.Write("Side 1: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Side 2: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Side 3: ");
            double sideC = double.Parse(Console.ReadLine());
            double perimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(perimeter * (perimeter - sideA) * (perimeter - sideB) * (perimeter - sideC));
            return area;
        }
        static double BySideAndAltitude()
        {
            Console.WriteLine("Please enter side and altitude for your triangle");
            Console.Write("Side : ");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Altitude: ");
            double altitude = double.Parse(Console.ReadLine());
            double area = (side * altitude) / 2;
            return area;

        }
        static void Main()
        {
            Console.WriteLine("Please choose one of the options by which you want to find the surface of a triangle");
            Console.WriteLine("Press \"1\" for side and an altitude");
            Console.WriteLine("Press \"2\" for three sides");
            Console.WriteLine("Press \"3\" for two sides and an angle between them");
            int userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1: Console.WriteLine("Your area is: {0:F2}", BySideAndAltitude()); break;
                case 2: Console.WriteLine("Your area is: {0:F2}", ByThreeSides()); break;
                case 3: Console.WriteLine("Your area is: {0:F2}", ByTwoSidesAndAngle()); break;
                default: Console.WriteLine("Please enter valid choice for action !");
                    break;
            }
        }
    }
}
