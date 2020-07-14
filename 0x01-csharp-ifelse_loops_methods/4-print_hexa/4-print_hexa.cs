using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            int decNum;
            for (decNum = 0; decNum < 99; decNum++)
            {
                Console.Write("{0} = 0x{0:x}\n", decNum);
            }
        }
    }
}
