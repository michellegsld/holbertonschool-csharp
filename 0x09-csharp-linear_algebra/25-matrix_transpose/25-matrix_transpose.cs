using System;

/// <summary>
/// A class reguarding matrices
/// </summary>
class MatrixMath
{
    /// <summary>
    /// A public method that transposes a matrix
    /// </summary>
    /// <param name="matrix">The matrix to transpose</param>
    /// <returns>The resulting matrix</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] final = {};

        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return (final);

        final = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                final[j, i] = matrix[i, j];

        return (final);
    }
}
