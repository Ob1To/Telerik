namespace TaskFrom1To4
{
    using System.Collections.Generic;
    using System.Text;
    public class Path
    {
        public List<Point3D> AllPoints = new List<Point3D>();

        public void AddPoint(Point3D point)
        {
            this.AllPoints.Add(point);
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (var point in this.AllPoints)
            {
                str.Append(point);
            }
            return str.ToString();
        }
    }
}
