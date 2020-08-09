using System;

namespace MyMath
{
    /// <summary>
    /// A class called Matrix with one method.
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// A method that divides all elements of a matrix.
        /// </summary>
        /// <param name="matrix">The matrix filled with what to divide.</param>
        /// <param name="num">The numebr to divide by.</param>
        /// <returns>A new matrix containing the divided elements or null.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                return (null);

            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return (null);
            }

            int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    newMatrix[i, j] = matrix[i, j] / num;

            return (newMatrix);
        }
    }
}
