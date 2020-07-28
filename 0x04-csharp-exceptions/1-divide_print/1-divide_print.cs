using System;
using System.Collections.Generic;

class Int
{
    public static void divide(int a, int b)
    {
        int total = 0;
        try
        {
            total = a / b;
        }
        catch (DivideByZeroException)
        {
            total = 0;
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {total}");
        }
    }
}
