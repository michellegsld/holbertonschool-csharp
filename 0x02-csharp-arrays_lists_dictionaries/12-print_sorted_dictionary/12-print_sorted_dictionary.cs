using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<String> sortedKeys = new List<String>();
        int i = 0;

        foreach (string key in myDict.Keys)
            sortedKeys.Add(key);

        sortedKeys.Sort();

        foreach(KeyValuePair<string, string> outitem in myDict)
        {
            foreach(KeyValuePair<string, string> item in myDict)
                if (sortedKeys[i] == item.Key)
                    Console.WriteLine(item.Key + ": " + item.Value);
            i++;
        }
    }
}
