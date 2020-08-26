using System;

/// <summary>
/// A class containing a public method reguarding vectors
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates a dot product of either 2D or 3D vectors
    /// </summary>
    /// <param name="vector1">The first vector</param>
    /// <param name="vector2">The second vector</param>
    /// <returns>The dot product</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.GetLength(0) != vector2.GetLength(0))
            return (-1);

        if (vector1.GetLength(0) != 2 && vector1.GetLength(0) != 3)
            return (-1);

        double sum = 0;

        for (int i = 0; i < vector1.GetLength(0); i++)
            sum += vector1[i] * vector2[i];

        return (sum);
    }
}
