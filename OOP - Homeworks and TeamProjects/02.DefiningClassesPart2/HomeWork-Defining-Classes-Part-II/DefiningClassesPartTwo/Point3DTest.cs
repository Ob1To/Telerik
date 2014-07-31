namespace TaskFrom1To4
{
    using System;
    public class Point3DTest
    {
        static void Main()
        {
            Point3D firstPoint = new Point3D(15, 8, 13);
            Point3D secondPoint = new Point3D(22, 14, 18);

            //Calculate the distance between this points
            Console.WriteLine(CalculatingDistance.CalculateDistanceBetweenTwoPoints(firstPoint, secondPoint));
            Path firstPath = new Path();


            //Add points to this paths
            firstPath.AddPoint(firstPoint);
            firstPath.AddPoint(secondPoint);
            firstPath.AddPoint(firstPoint);

            //Save the paths in text file
            PathStorage.SavePath(firstPath);

            Path result = PathStorage.LoadPath();

            Console.WriteLine(result.ToString());
        }
    }
}
