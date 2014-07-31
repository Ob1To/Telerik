namespace GSM_Homework
{
    using System.Text;
    using System;
    public class Display
    {
        private double? size;

        private int? numberOfColors;

        public Display(double? Size = null, int? numberOfColors = null)
        {
            this.Size = Size;
            this.NumberOfColors = numberOfColors;
        }

        public int? NumberOfColors
        {
            get { return numberOfColors; }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentException("Number of colors cannot be negative number !");
                }
                numberOfColors = value;
            }
        }
        

        public double? Size
        {
            get { return size; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Size of the screen cannot be negative number !");
                }
                size = value;
            }
        }
        public override string ToString()
        {
            StringBuilder displayInfo = new StringBuilder();
            displayInfo.AppendLine("                      ***   DISPLAY INFO   ***");
            displayInfo.AppendLine();
            displayInfo.AppendLine();
            if (this.Size == null && this.NumberOfColors == null)
            {
                displayInfo.AppendLine("        YOUR DISPLAY DOESNT HAVE ANY SIZE AND NUMBER OF COLORS\n       BECAUSE IT IS MADE IN CHINA !!!");
            }
            if (this.Size != null)
            {
                displayInfo.AppendLine("            Size:     " + this.Size + " inchs");
                displayInfo.AppendLine();
            }
            if (this.NumberOfColors != null)
            {
                displayInfo.AppendLine("Number Of Colors:     " + this.NumberOfColors);
                displayInfo.AppendLine();
            }
            return displayInfo.ToString();
        }
    }
}
