using System;

class DeclareNullableTypes
{
    static void Main()
    {
        int x = 7;
        int? nx = x;
        Console.WriteLine(nx.HasValue); // True
        x = nx.Value;
        Console.WriteLine(x);  // 7
        
        double y = 7.696969696969696;
        double? ny = y;
        Console.WriteLine(ny.HasValue); // True
        y = ny.Value;
        Console.WriteLine(y); // 7.696969696969696

        int z = 10;
        int? nz = null;
        Console.WriteLine(nz.HasValue); // False
        z = nz.GetValueOrDefault();
        Console.WriteLine(z); // 0

        double t = 10.696969696969696;
        double? nt = null;
        Console.WriteLine(nt.HasValue); // False
        t = nt.GetValueOrDefault();
        Console.WriteLine(t); // 0
    }
}

