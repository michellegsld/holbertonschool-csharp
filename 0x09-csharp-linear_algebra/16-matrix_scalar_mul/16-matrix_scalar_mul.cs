using System;

/// <summary>
/// A class regarding matrices
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix by a scalar
    /// </summary>
    /// <param name="matrix">The matrix to be multiplied</param>
    /// <param name="scalar">The scalar that is multiplying</param>
    /// <returns>The final matrix or -1</returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] fail = { { -1 } };

        if (matrix1.GetLength(0) != matrix1.GetLength(1))
            return (fail);

        if (matrix1.GetLength(0) != 2 && matrix1.GetLength(0) != 3)
            return (fail);

        double[,] total = null;

        if (matrix1.GetLength(0) == 2)
            total = new double[2, 2];
        else
            total = new double[3, 3];

        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix1.GetLength(1); j++)
                total[i, j] = scalar * matrix1[i, j];

        return (total);
    }
}
