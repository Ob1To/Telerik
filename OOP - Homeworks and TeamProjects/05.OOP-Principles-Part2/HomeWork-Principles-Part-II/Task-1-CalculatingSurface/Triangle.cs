namespace Task_1_CalculatingSurface
{
    using System;
    public class Triangle : Shape
    {
        public Triangle(int width, int height) : base(width, height)
        {

        }


        public override void CalculateSurface()
        {
            int surfaceOfTriangle = ((this.Height * this.Width) / 2);
            Console.WriteLine(surfaceOfTriangle);
        }
    }
}
