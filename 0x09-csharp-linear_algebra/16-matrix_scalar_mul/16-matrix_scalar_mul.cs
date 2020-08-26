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

        if (matrix.GetLength(0) != matrix.GetLength(1))
            return (fail);

        if (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3)
            return (fail);

        double[,] total = null;

        if (matrix.GetLength(0) == 2)
            total = new double[2, 2];
        else
            total = new double[3, 3];

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                total[i, j] = scalar * matrix[i, j];

        return (total);
    }
}
