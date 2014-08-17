using System;
using System.Text;

public struct Point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    private static readonly Point3D startPoint = new Point3D(0, 0, 0);

    public Point3D(int X, int Y, int Z)
        : this()
    {
        this.X = X;
        this.Y = Y;
        this.Z = Z;
    }

    public static Point3D StartPoint
    {
        get { return startPoint; }
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendFormat("{0}, {1}, {2}", this.X, this.Y, this.Z);
        return result.ToString();
    }
}