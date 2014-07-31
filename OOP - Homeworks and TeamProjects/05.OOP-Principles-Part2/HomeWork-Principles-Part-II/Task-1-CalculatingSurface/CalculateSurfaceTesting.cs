namespace Task_1_CalculatingSurface
{
    using System;
    public class CalculateSurfaceTesting
    {
        static void Main()
        {
            var rectangle = new Rectangle(6, 4);
            rectangle.CalculateSurface();

            var triangle = new Triangle(8, 4);
            triangle.CalculateSurface();

            var circle = new Circle(7);
            circle.CalculateSurface();
            
        }
    }
}
