using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        List<int> sortedVals = new List<int>();
        int i = 0;

        if (myList.Count <= 0)
            return "None";

        foreach (int val in myList.Values)
            sortedVals.Add(val);

        sortedVals.Sort();
        sortedVals.Reverse();

        foreach(KeyValuePair<string, int> outitem in myList)
        {
            foreach(KeyValuePair<string, int> item in myList)
                if (sortedVals[i] == item.Value)
                    return item.Key;
            i++;
        }

        return "None";
    }
}
