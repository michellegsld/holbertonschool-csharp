using System;

/// <summary>
/// A class reguarding matrices
/// </summary>
class MatrixMath
{
    /// <summary>
    /// A public class that multiplies two matrices (look at end for thought process)
    /// </summary>
    /// <param name="matrix1">The first matrix</param>
    /// <param name="matrix2">The second matrix</param>
    /// <returns>The final product or -1</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] fail = { { -1 } };

        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return (fail);

        double[,] total = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
            for (int j = 0; j < matrix2.GetLength(1); j++)
                for (int k = 0; k < matrix1.GetLength(1); k++)
                    total[i, j] += matrix1[i, k] * matrix2[k, j];

        return (total);
    }
}

// Thought process:
// GetLength(0) is how many rows there are
// GetLength(1) is how many columns (in a row) there are
// GetLength(0) of matrix1 has to be equal to getLength(1) of matrix2
// First we need to loop through rows of matrix1 (thats how the math goes)
//    int i can represent the row number in matrix1
// Then we need to loop through the columns of matrix2 (as thats what gonna multiply)
//    int j can represent the column number in matrix2
// Since i can't work with j and same vice versa, need another variable
// (this is because the way matrices are being looped through are different)
//    int k can represent position from start to end in current row/column
// So need final loop from 0 to GetLength(1) of matrix1 as is same as GetLength(0) of matrix2
// (as number of rows in matrix1 must be equal to number of column in matrix2)=
// Then set the new matrix position at [i, j] AFTER adding the current positions in matrix1 and matrix2
