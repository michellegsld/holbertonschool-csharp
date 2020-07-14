using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ten, one, num;
            for (ten = 0; ten < 9; ten++)
            {
                for (one = ten + 1; one < 10; one++)
                {
                    num = (ten * 10) + one;
                    if (num != 89)
                    {
                        Console.Write("{0:00}, ", num);
                    }
                    else
                    {
                        Console.Write($"{num}\n");
                    }
                }
            }
        }
    }
}
