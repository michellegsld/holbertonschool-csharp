using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int total = 0;

        foreach(KeyValuePair<string, string> item in myDict)
            total++;

        return total;
    }
}
