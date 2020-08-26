using System;
using System.Math;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.GetLength(0) != 2 && vector.GetLength(0) != 3)
            return (-1);

        int sum = 0;

        foreach (int num in vector)
        {
            sum += Pow(num, 2.0);
        }

        return (Sqrt(sum));
    }
}
