using System;

class Program
{
    static void Main(string[] args)
    {
        int[][] jagged = new int[][]
        {
            new int[4],
            new int[7],
            new int[2]
        };

        for (int i = 0; i < jagged.Length; i++)
        {
            for (int j = 0; j < jagged[i].Length; j++)
            {
                jagged[i][j] = j;

                Console.Write(jagged[i][j]);
                if (j < jagged[i].Length - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
