using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count == 0)
            Console.WriteLine("List is empty");
            /* return -1;  <- not needed cuz if length is 0
               then would return -1 below anyway */

        myList.Sort();

        return myList[myList.Count - 1];
    }
}
