using System;

/// <summary>
/// A class reguarding matrices
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Shears a square 2D matrix by a given shear factor
    /// </summary>
    /// <param name="matrix">The 2D matrix to shear</param>
    /// <param name="direction">The direction in which to shear</param>
    /// <param name="factor">The factor in how much to shear</param>
    /// <returns>The resulting matrix after shearing or -1</returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] fail = { { -1 } };

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (fail);

        if (direction != 'x' && direction != 'y')
            return (fail);

        double[,] total = new double[2, 2];

        if (direction == 'x')
        {
            total[0, 0] = matrix[0, 0] + factor * matrix[0, 1];
            total[0, 1] = matrix[0, 1];
            total[1, 0] = matrix[1, 0] + factor * matrix[0, 1];
            total[1, 1] = matrix[1, 1];
        }
        else
        {
            total[0, 0] = matrix[0, 0];
            total[0, 1] = matrix[0, 0] * factor + matrix[0, 1];
            total[1, 0] = matrix[1, 0];
            total[1, 1] = matrix[1, 0] * factor + matrix[1, 1];
        }
}
