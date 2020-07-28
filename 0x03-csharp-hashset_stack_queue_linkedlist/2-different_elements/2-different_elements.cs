using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> uncommonList = new List<int>();

        foreach (int element in list1)
            if (!list2.Contains(element))
                uncommonList.Add(element);

        foreach (int element in list2)
            if (!list1.Contains(element))
                uncommonList.Add(element);

        uncommonList.Sort();

        return uncommonList;
    }
}
