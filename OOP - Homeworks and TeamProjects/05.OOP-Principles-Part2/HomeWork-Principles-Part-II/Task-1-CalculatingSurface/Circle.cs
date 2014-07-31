namespace Task_1_CalculatingSurface
{
    using System;
    public class Circle : Shape
    {
        public Circle(int radius) : base(radius, radius)
        {

        }

        public override void CalculateSurface()
        {
            Console.WriteLine(Math.PI * (this.Width / 2) * (this.Height / 2));
        }
    }
}
