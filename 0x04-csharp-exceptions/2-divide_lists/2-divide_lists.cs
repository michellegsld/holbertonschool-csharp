using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> totals = new List<int>();
        int i = 0;

        for (; i < listLength; i++)
        {
            try
             {
                totals.Add(list1[i] / list2[i]);
             }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                totals.Add(0);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return(totals);
    }
}
