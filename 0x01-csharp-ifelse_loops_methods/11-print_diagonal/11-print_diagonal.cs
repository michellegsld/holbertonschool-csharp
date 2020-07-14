using System;

namespace _11_print_diagonal
{
    class Line
    {
        public static void PrintDiagonal(int length)
        {
            int slash;
            string space = "";

            if (length > 0)
            {
                for (slash = 0; slash < length; slash++)
                {
                    Console.WriteLine("{0}\\", space);
                    space += " ";
                }
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
