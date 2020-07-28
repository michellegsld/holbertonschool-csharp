using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        var node = myLList.First;
        int i = 0;

        if (index < 0 || index >= myLList.Count)
            return;

        while (i < index && node != null)
        {
            i++;
            node = node.Next;
        }

        if (node != null)
            myLList.Remove(node);
    }
}
