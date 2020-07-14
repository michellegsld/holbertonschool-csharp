using System;

namespace _10_print_line
{
    class Line
    {
        public static void PrintLine(int length)
        {
            int i;

            if (length > 0)
            {
                for (i = 0; i < length; i++)
                {
                    Console.Write("_");
                }
            }
            Console.WriteLine();
        }
    }
}
