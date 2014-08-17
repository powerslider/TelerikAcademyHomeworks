using System;
using System.Collections.Generic;

class Path
{
    private List<Point3D> points = new List<Point3D>();

    public List<Point3D> Paths
    {
        get { return this.points; }
    }

    public void AddPoint(Point3D point)
    {
        points.Add(point);
    }

    public void ClearPath()
    {
        points.Clear();
    }
}

