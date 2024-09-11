using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> unionList = new List<int>();
        
        int maxCount = list1.Count > list2.Count ? list1.Count : list2.Count;
        List<int> bigList = list1.Count > list2.Count ? list1 : list2;
        List<int> smallList = list1.Count > list2.Count ? list2 : list1;
        for (int i = 0; i < maxCount; i++)
        {
            if (smallList.Contains(bigList[i]))
            {
                unionList.Add(bigList[i]);
            }
        }
        unionList.Sort();
        return unionList;
    }
}