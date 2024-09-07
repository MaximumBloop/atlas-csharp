using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }
        string maxkey = null;
        foreach (string key in myList.Keys)
        {
            maxkey = key;
            break;
        }
        foreach(string key in myList.Keys)
        {
            if (myList[key] > myList[maxkey])
            {
                maxkey = key;
            }
        }
        return maxkey;
    }
}