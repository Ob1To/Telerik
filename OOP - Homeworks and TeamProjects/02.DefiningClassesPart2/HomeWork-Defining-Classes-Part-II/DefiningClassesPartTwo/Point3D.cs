
namespace TaskFrom1To4
{
    using System;
    using System.Collections.Generic;
    public struct Point3D
    {
        private static readonly Point3D zeroPoint = new Point3D(0, 0, 0);
        public int PointX { get; set; }
        public int PointY { get; set; }
        public int  PointZ { get; set; }

        public static Point3D ZeroPoint
        {
            get { return zeroPoint; }
        }

        
        public Point3D(int pointX, int pointY, int pointZ) : this()
        {
            this.PointX = pointX;
            this.PointY = pointY;
            this.PointZ = pointZ;
        }
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}",PointX,PointY,PointZ);
        }
    }
}
