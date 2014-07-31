namespace TaskFrom1To4
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public static class PathStorage
    {
        public static void SavePath(Path path)
        {
            using (StreamWriter writer = new StreamWriter(@"../../Result.txt"))
            {
                foreach (var point in path.AllPoints)
                {
                    writer.WriteLine(point);
                }
            }
        }

        public static Path LoadPath()
        {
            Path loadedPath = new Path();
            using (StreamReader reader = new StreamReader(@"../../Result.txt"))
            {
                string row = reader.ReadLine();
                while (row != null)
                {
                    string[] arr = row.Split(new char[] { ' ', ','},StringSplitOptions.RemoveEmptyEntries);
                    loadedPath.AddPoint(new Point3D(int.Parse(arr[0]), int.Parse(arr[1]), int.Parse(arr[2])));
                    row = reader.ReadLine();
                }
            }

            return loadedPath;
        }
    }
}
