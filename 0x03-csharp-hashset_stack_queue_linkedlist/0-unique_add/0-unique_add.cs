using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        var hashSet = new HashSet<int>(myList);
        int total = 0;

        foreach (int element in hashSet)
            total += element;

        return total;
    }
}
