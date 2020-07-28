using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count > 0)
        {
            int value = myLList.First;
            myLList.RemoveFirst();
            return value;
        }
        return 0;
    }
}
