namespace Task_1_CalculatingSurface
{
    public abstract class Shape
    {
        private int width;
        private int height;


        public Shape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        

        public abstract void CalculateSurface();
    }
}
