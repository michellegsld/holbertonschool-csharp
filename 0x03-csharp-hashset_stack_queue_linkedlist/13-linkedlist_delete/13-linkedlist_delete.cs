﻿using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index >= 0 && index < myLList.Count)
            myLList.Remove(index);
    }
}
