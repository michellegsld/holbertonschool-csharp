using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (n >= 0 && n < myLList.Count)
        {
            int i = 0;

            foreach (int element in myLList)
            {
                if (i == n)
                    return element;
                i++;
            }
        }

        return 0;
    }
}
