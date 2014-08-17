using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class TestProgram
{
    static void Main()
    {
        Point3D firstPoint = new Point3D(1, 2, 3);
        Point3D secondPoint = new Point3D(10, 20, 30);
        Point3D thirdPoint = new Point3D(40, 50, 60);

        double distanceBetweenPoints = Distance3D.CalcDistance(firstPoint, secondPoint);
        Console.WriteLine(distanceBetweenPoints);

        Path pathOne = new Path();
        pathOne.AddPoint(firstPoint);
        pathOne.AddPoint(secondPoint);
        pathOne.AddPoint(thirdPoint);

        Path pathTwo = new Path();
        pathTwo.AddPoint(thirdPoint);
        pathTwo.AddPoint(firstPoint);
        pathTwo.AddPoint(secondPoint);

        PathStorage.SavePath(pathOne);
        PathStorage.SavePath(pathTwo);

        List<Path> pathList = PathStorage.LoadPath();
        foreach (var point in pathList)
        {
            Console.WriteLine("Path loaded!");
        }

    }
}

