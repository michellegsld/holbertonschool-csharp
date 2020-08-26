using System;
using System.Collections.Generic;

/// <summary>
/// A class containing a public method reguarding vectors
/// </summary>
class VectorMath
{
    /// <summary>
    /// Adds two vectors and returns the resulting vector
    /// </summary>
    /// <param name="vector1">The first vector to add</param>
    /// <param name="vector2">The second vector to add</param>
    /// <returns>The sum of two vectors, else -1 if not 2D or 3D</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] fail = {-1};

        if (vector1.GetLength(0) != vector2.GetLength(0))
            return (fail);
        if (vector1.GetLength(0) != 2 && vector1.GetLength(0) != 3)
            return (fail);

        if (vector1.GetLength(0) == 2)
        {
            double[] sum = {vector1[0] + vector2[0], vector1[1] + vector2[1]};
            return sum;
        }
        else
        {
            double[] sum = {vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2]};
            return (sum);
        }
    }
}
