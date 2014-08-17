using System;


public class TestGenericMatrix
{
    static void Main()
    {
        int[,] matrix1 = new int[,]
        {
            {10, 20, -30},
            {20, -10, 30},
            {30, 20, 10}
        };

        int[,] matrix2 = new int[,]
        {
            {4, 5, 6},
            {-1, 3, 5},
            {7, 8, 9}
        };

        Matrix<int> m1 = new Matrix<int>(3, 3, matrix1);
        Matrix<int> m2 = new Matrix<int>(3, 3, matrix2);

        
        Console.WriteLine(m1 + m2);
        Console.WriteLine(m1 - m2);
        Console.WriteLine(m1 * m2);
    }
}
