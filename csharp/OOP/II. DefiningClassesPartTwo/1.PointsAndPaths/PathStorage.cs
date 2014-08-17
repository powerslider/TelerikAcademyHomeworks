using System;
using System.Collections.Generic;
using System.IO;

class PathStorage
{
    public static void SavePath(Path path)
    {
        StreamWriter writer = new StreamWriter("SavedPaths.txt");
        using (writer)
        {
            foreach (var point in path.Paths)
            {
                writer.WriteLine(point);
            }
        }
    }

    public static List<Path> LoadPath()
    {
        Path loadedPath = new Path();
        List<Path> allPaths = new List<Path>();
        StreamReader reader = new StreamReader("SavedPaths.txt");
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                if (line != "-")
                {
                    Point3D point = new Point3D();
                    string[] pointCoords = line.Split(',');
                    point.X = int.Parse(pointCoords[0]);
                    point.Y = int.Parse(pointCoords[1]);
                    point.Z = int.Parse(pointCoords[2]);
                    loadedPath.AddPoint(point);
                    
                    line = reader.ReadLine();
                }
                else
                {
                    loadedPath.ClearPath();
                }
                allPaths.Add(loadedPath);
            }
        }
        return allPaths;
    }
}

