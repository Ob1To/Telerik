namespace Task_1_CalculatingSurface
{
    using System;
    public class Rectangle : Shape
    {
        public Rectangle(int width , int height) : base(width, height)
        {

        }


        public override void CalculateSurface()
        {
            Console.WriteLine(this.Width*this.Height);
        }
    }
}
