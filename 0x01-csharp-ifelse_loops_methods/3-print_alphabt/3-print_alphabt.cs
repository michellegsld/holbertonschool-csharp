﻿using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            for (ch = 'a'; ch <= 'z'; ch++)
            {
                if (ch != 'e' && ch != 'q')
                {
                    Console.Write(ch);
                }
            }
        }
    }
}
