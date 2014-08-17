using System;

class MatrixFilling
{
    static void Main()
    {
        Console.Write("size: ");
        int n = int.Parse(Console.ReadLine());
            
        Console.Write("choice(1 - 4): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                DownRightMatrix(n);
                break;
            case 2:
                DiagonalMatrix(n);
                break;
            case 3:
                UpDownMatrix(n);
                break;
            case 4:
                SpiralMatrix(n);
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

    public static void DownRightMatrix(int n)
    {
        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = i + 1 + j * n;
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    public static void DiagonalMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int i = n - 1, j = 0;
        //current height
        int count = 1;

        //fill elements under the diagonal
        for (int k = 1; k <= (n * n) / 2 + n / 2 ; )
        {
            while (i < n)
            {
                matrix[i, j] = k++;
                i++;
                j++;
            }
            count++;
            i = n - count;
            j = 0;
        }

        //fill elements above the diagonal
        i = 0;
        j = n - 1;
        count = 0;
        for (int k = n * n; k > (n * n) / 2 + n / 2; )
        {
            while (i >= 0)
            {
                matrix[i, j] = k--;
                i--;
                j--;
            }
            count++;
            i = count;
            j = n - 1;
        }

        //print matrix
        for (int k = 0; k < n; k++)
        {
            for (int l = 0; l < n; l++)
            {
                Console.Write("{0,4}", matrix[k, l]);
            }
            Console.WriteLine();
        }
    }

    public static void UpDownMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int i = 0, j = 0;
        int topBorder = 0;
        int bottomBorder = n;

        for (int k = 1; k <= n * n; )
        {
            //down
            while (i < bottomBorder)
            {
                matrix[i++, j] = k++;
            }
            i--;
            j++;

            //up
            while (i >= topBorder)
            {
                matrix[i--, j] = k++;
            }
            i++;
            j++;
        }

        for (int k = 0; k < n; k++)
        {
            for (int l = 0; l < n; l++)
            {
                Console.Write("{0,4}", matrix[k, l]);
            }
            Console.WriteLine();
        }
    }

    public static void SpiralMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int i = 0, j = 0;
        int leftTopBorder = 0;
        int rightBottomBorder = n;

        for (int k = 1; k <= n * n; )
        {
            //down
            while (i < rightBottomBorder)
            {
                matrix[i++, j] = k++;
            }
            i--;
            j++;

            //right
            while (j < rightBottomBorder)
            {
                matrix[i, j++] = k++;
            }
            i--;
            j--;

            //up
            while (i >= leftTopBorder)
            {
                matrix[i--, j] = k++;
            }
            i++;
            j--;

            //left
            while (j > leftTopBorder)
            {
                matrix[i, j--] = k++;
            }
            i++;
            j++;
                
            leftTopBorder++;
            rightBottomBorder--;
        }

        for (int k = 0; k < n; k++)
        {
            for (int l = 0; l < n; l++)
            {
                Console.Write("{0,4}", matrix[k, l]);                    
            }
            Console.WriteLine();
        }
    }
}

