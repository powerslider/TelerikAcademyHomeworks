using System;

class TestBitArray64 
{
    static void Main()
    {
        BitArray64 bitArrayOne = new BitArray64(9999);
        Console.WriteLine("First number:");
        foreach (var bit in bitArrayOne)
        {
            Console.Write(bit);
        }
        Console.WriteLine();
        
        BitArray64 bitArrayTwo = new BitArray64(8888);
        Console.WriteLine("\nSecond number:");
        foreach (var bit in bitArrayTwo)
        {
            Console.Write(bit);
        }
        Console.WriteLine("\n");

        Console.WriteLine("---------------Test Equals() method-----------------");
        Console.WriteLine(bitArrayOne.Equals(bitArrayTwo));
        Console.WriteLine(bitArrayOne == bitArrayTwo);
        Console.WriteLine(bitArrayOne != bitArrayTwo);
        Console.WriteLine();
       
        Console.WriteLine("---------------Test ToString() method-----------------");
        Console.WriteLine(bitArrayOne);
        Console.WriteLine("\n---------------Test overriden operator []-----------------");
        Console.WriteLine(bitArrayOne[0]);
        Console.WriteLine(bitArrayTwo[0]);

        Console.WriteLine("\n---------------Test GetHashCode() method-----------------");
        Console.WriteLine(bitArrayOne.GetHashCode());
        Console.WriteLine(bitArrayTwo.GetHashCode());
        Console.WriteLine();        
    }
}

