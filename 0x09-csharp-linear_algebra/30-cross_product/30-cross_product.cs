using System;

/// <summary>
/// A class reguarding Vectors
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates the cross product of two 3D vectors
    /// </summary>
    /// <param name="vector1">First vector</param>
    /// <param name="vector2">Second vector</param>
    /// <returns>The cross product result</returns>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        double[] fail = { -1 };

        if (vector1.GetLength(0) != 3)
            return (fail);
        if (vector2.GetLength(0) != 3)
            return (fail);

        double[] total = new double[3];

        double x1 = vector1[0];
        double y1 = vector1[1];
        double z1 = vector1[2];
        double x2 = vector2[0];
        double y2 = vector2[1];
        double z2 = vector2[2];

        total[0] = y1 * z2 - y2 * z1;
        total[1] = x2 * z1 - x1 * z2;
        total[2] = x1 * y2 - y1 * x2;

        return (total);
    }
}
