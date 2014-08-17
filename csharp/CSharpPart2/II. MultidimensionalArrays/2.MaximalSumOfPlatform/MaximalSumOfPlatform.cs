using System;

class MaximalSumOfPlatform
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("matrix[{0}, {1}] = ", i , j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        for (int i = bestRow; i < bestRow + 3; i++)
        {
            for (int j = bestCol; j < bestCol + 3; j++)
            {
                Console.Write(matrix[i, j] + " ");                   
            }
            Console.WriteLine();
        }
    }
}

