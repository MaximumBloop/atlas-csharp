using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        List<int> uniq = new List<int>();

        foreach (var i in myList)
        {
            bool isUnique = true;
            foreach (var j in uniq)
            {
                if (i == j)
                {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique)
            {
            uniq.Add(i);
            }
        }
        int sum = 0;
        foreach (var i in uniq)
        {
            sum += i;
        }
        return sum;
    }
}