using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            for (num = 1; num <= 100; num++)
            {
                if (num % 15 == 0)
                {
                    Console.Write("FizzBuzz");
                }
                else if (num % 3 == 0)
                {
                    Console.Write("Fizz");
                }
                else if (num % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else
                {
                    Console.Write(num);
                }
                if (num == 100)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
