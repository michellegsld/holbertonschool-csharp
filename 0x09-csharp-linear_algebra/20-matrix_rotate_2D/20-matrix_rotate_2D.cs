﻿using System;

/// <summary>
/// A class reguarding matrices
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians
    /// </summary>
    /// <param name="matrix">The matrix to rotate</param>
    /// <param name="angle">The angle in which to rotate by</param>
    /// <returns>The resulting matrix after rotating</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] fail = { { -1 } };

        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return (fail);

        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return (fail);

        double[,] total = new double[2, 2];

        double x1 = matrix[0, 0];
        double y1 = matrix[0, 1];
        double x2 = matrix[1, 0];
        double y2 = matrix[1, 1];

        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        total[0, 0] = Math.Round((x1 * cos), 2) - Math.Round((y1 * sin), 2);
        total[0, 1] = Math.Round((x1 * sin), 2) + Math.Round((y1 * cos), 2);
        total[1, 0] = Math.Round((x2 * cos), 2) - Math.Round((y2 * sin), 2);
        total[1, 1] = Math.Round((x2 * sin), 2) + Math.Round((y2 * cos), 2);

        return (total);
    }
}
