using System;

/// <summary>
/// A class reguarding matrices
/// </summary>
class MatrixMath
{
    /// <summary>
    /// A public method that calculates the inverse of a 2D matrix
    /// </summary>
    /// <param name="matrix">The matrix to find the inverse of</param>
    /// <returns>The inverse of the matrix</returns>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] fail = { { -1 } };

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (fail);

        double a = matrix[0, 0];
        double b = -1 * matrix[0, 1];
        double c = -1 * matrix[1, 0];
        double d = matrix[1, 1];
        double determinant = a * d - b * c;

        if (determinant == 0)
            return (fail);

        double[,] inverse = new double[2, 2];

        inverse[0, 0] = d / determinant;
        inverse[0, 1] = b / determinant;
        inverse[1, 0] = c / determinant;
        inverse[1, 1] = a / determinant;

        return (inverse);
    }
}
