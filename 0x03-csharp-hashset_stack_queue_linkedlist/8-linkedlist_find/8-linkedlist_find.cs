using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int position = -1;

        foreach (int element in myLList)
        {
            position++;
            if (element == value)
                return position;
        }

        return -1;
    }
}
