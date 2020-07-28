using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int total = 0;

        foreach (int element in myLList)
            total += element;

        return total;
    }
}
