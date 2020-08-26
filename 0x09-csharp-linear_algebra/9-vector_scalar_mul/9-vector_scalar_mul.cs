using System;

/// <summary>
/// A class containing a public method reguarding vector and scalars
/// </summary>
class VectorMath
{
    /// <summary>
    /// Multiplies a vector by a scalar
    /// </summary>
    /// <param name="vector">The vector to be multiplied</param>
    /// <param name="scalar">The scalar to multiply the vector by</param>
    /// <returns>Either the vector * scalar or -1</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] fail = {-1};

        if (vector.GetLength(0) != 2 && vector.GetLength(0) != 3)
            return (fail);

        if (vector.GetLength(0) == 2)
        {
            double[] sum = {scalar * vector[0], scalar * vector[1]};
            return (sum);
        }
        else
        {
            double[] sum = {scalar * vector[0], scalar * vector[1], scalar * vector[2]};
            return (sum);
        }
    }
}
