using System;

/// <summary>
/// A class reguaring matrices
/// </summary>
class MatrixMath
{
    /// <summary>
    /// A public method that adds two matrices
    /// </summary>
    /// <param name="matrix1">The first matrix</param>
    /// <param name="matrix2">The second matrix</param>
    /// <returns>The sum of both matrices or -1</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] fail = { { -1 } };

        if (matrix1.GetLength(0) != matrix1.GetLength(1) || matrix2.GetLength(0) != matrix2.GetLength(1))
            return (fail);

        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
            return (fail);

        if (matrix1.GetLength(0) != 2 && matrix1.GetLength(0) != 3)
            return (fail);

        double[,] sum = null;

        if (matrix1.GetLength(0) == 2)
            sum = new double[2, 2];
        else
            sum = new double[3, 3];

        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix1.GetLength(1); j++)
                sum[i, j] = matrix1[i, j] + matrix2[i, j];

        return (sum);
    }
}
