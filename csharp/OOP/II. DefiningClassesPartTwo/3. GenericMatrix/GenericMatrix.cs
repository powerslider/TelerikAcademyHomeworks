using System;
using System.Collections.Generic;
using System.Text;


public class Matrix<T> 
{
    #region Fields

    private readonly int rows;
    private readonly int cols;
    private T[,] matrix;

    #endregion

    #region Constructors

    public Matrix()
    //: this()
    {
    }

    public Matrix(int rows, int cols)
        : this(rows, cols, new T[rows, cols])
    {
    }

    public Matrix(int rows, int cols, T[,] matr)
    {
        this.rows = rows;
        this.cols = cols;
        this.matrix = matr;
    }

    #endregion

    #region Properties

    public int GetRows
    {
        get
        {
            return this.rows;
        }
    }

    public int GetCols
    {
        get
        {
            return this.cols;
        }
    }

    public T this[int i, int j]
    {
        get
        {
            if (i < 0 || j < 0 || i > this.rows || j > this.cols)
            {
                throw new IndexOutOfRangeException("Trying to access nonexisting element!");
            }
            return matrix[i, j];
        }
        set
        {
            matrix[i, j] = value;
        }
    }

    #endregion

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();

        for (int i = 0; i < this.GetRows; i++)
        {
            builder.Append('\n');
            for (int j = 0; j < this.GetCols; j++)
            {
                builder.Append(this.matrix[i, j]).Append(" ");
            }
        }
        return builder.ToString();
    }


    public void Duplicate(Matrix<T> matr)
    {
        if ((this.GetCols != matr.GetCols) || (this.GetRows != matr.GetRows))
        {
            throw new FormatException("Matrises do not have the same dimensions!!!");
        }
        else
        {
            for (int i = 0; i < matr.GetRows; i++)
            {
                for (int j = 0; j < matr.GetCols; j++)
                {
                    matr[i, j] = this.matrix[i, j];
                }
            }
        }
    }

    //Operators overloading
    public static Matrix<T> operator +(Matrix<T> leftMatrix, Matrix<T> rightMatrix)
    {
        if ((leftMatrix.GetRows != rightMatrix.GetRows) || (leftMatrix.GetCols != rightMatrix.GetCols))
        {
            throw new FormatException("Addition (+) can't be used on matrices with diferent dimensions");
        }
        else
        {
            Matrix<T> result = new Matrix<T>(leftMatrix.GetRows, leftMatrix.GetCols);
            for (int i = 0; i < leftMatrix.GetRows; i++)
            {
                for (int j = 0; j < leftMatrix.GetCols; j++)
                {
                    result.matrix[i, j] = (dynamic)leftMatrix.matrix[i, j] + (dynamic)rightMatrix.matrix[i, j];
                }
            }
            return result;
        }
    }
    
    public static Matrix<T> operator -(Matrix<T> leftMatrix, Matrix<T> rightMatrix)
    {
        if ((leftMatrix.GetRows != rightMatrix.GetRows) || (leftMatrix.GetCols != rightMatrix.GetCols))
        {
            throw new FormatException("Substraction (-) can't be used on matrices with different dimensions");
        }
        else
        {
            Matrix<T> result = new Matrix<T>(leftMatrix.GetRows, leftMatrix.GetCols);
            for (int i = 0; i < leftMatrix.GetRows; i++)
            {
                for (int j = 0; j < leftMatrix.GetCols; j++)
                {
                    result.matrix[i, j] = (dynamic)leftMatrix.matrix[i, j] - (dynamic)rightMatrix.matrix[i, j];
                }
            }
            return result;
        }
    }

    public static Matrix<T> operator *(Matrix<T> leftMatrix, Matrix<T> rightMatrix)
    {
        if (leftMatrix.GetCols != rightMatrix.GetRows)
        {
            throw new FormatException("Multiplication (*) can be used on matrices, one of which has" +
            "the same number of rows which equals the number of columns of the second matrix!!!");
        }
        else
        {
            int rows = leftMatrix.GetRows;
            int cols = rightMatrix.GetCols;
            Matrix<T> result = new Matrix<T>(rows, cols);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dynamic sum = 0;
                    for (int k = 0; k < cols; k++)
                    {
                        sum = sum + (dynamic)leftMatrix.matrix[i, k] * (dynamic)rightMatrix.matrix[k, j];
                    }
                    result.matrix[i, j] = sum;
                }
            }

            return result;
        }
    }
}


