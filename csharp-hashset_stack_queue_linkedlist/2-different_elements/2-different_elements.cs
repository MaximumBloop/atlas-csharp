using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> unionList = new List<int>();
        List<int> differenceList = new List<int>();
        
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

        foreach (int item in unionList)
        {
            if (smallList.Contains(item))
            {
                smallList.Remove(item);
            }
            if (bigList.Contains(item))
            {
                bigList.Remove(item);
            }
        }
        differenceList.AddRange(bigList);
        differenceList.AddRange(smallList);
        differenceList.Sort();
        return differenceList;
    }
}