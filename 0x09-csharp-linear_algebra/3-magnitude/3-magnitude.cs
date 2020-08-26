using System;
using System.Math;

/// <summary>
/// A class containing a public method reguarding vectors
/// </summary>
class VectorMath
{
    /// <summary>
    /// To find the magnitude or length of a 2D or 3D vector
    /// </summary>
    /// <param name="vector">The vector in which to find the length of</param>
    /// <returns>The length of the vector, else -1 if not 2D or 3D</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.GetLength(0) != 2 && vector.GetLength(0) != 3)
            return (-1);

        int sum = 0;

        foreach (int num in vector)
            sum += Pow(num, 2.0);

        return (Round(Sqrt(sum), 2));
    }
}
