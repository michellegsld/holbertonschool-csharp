using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            for (num = 0; num < 100; num++)
            {
                if (num != 99)
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
