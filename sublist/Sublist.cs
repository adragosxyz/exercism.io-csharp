using System;
using System.Collections.Generic;

public enum SublistType
{
    Equal,
    Unequal,
    Superlist,
    Sublist
}

public static class Sublist
{
    public static SublistType Classify<T>(List<T> list1, List<T> list2)
        where T : IComparable
    {
        if (list1.Count==list2.Count)
        {
            for (int i=0;i<list1.Count;i++)
            {
                if (!EqualityComparer<T>.Default.Equals(list1[i],list2[i])) return SublistType.Unequal;
            }
            return SublistType.Equal;
        } else if (list1.Count<list2.Count)
        {
            int k = 0;
            if (k==list1.Count) return SublistType.Sublist;
            for (int i=0;i<list2.Count;i++)
            {
                if (EqualityComparer<T>.Default.Equals(list1[k],list2[i]))
                {
                    k++;
                } else {
                    i = i-k;
                    k=0;
                }
                if (k==list1.Count) return SublistType.Sublist;
            }
        } else {
            int k = 0;
            if (k==list2.Count) return SublistType.Superlist;
            for (int i=0;i<list1.Count;i++)
            {
                if (EqualityComparer<T>.Default.Equals(list1[i],list2[k]))
                {
                    k++;
                } else {
                    i = i-k;
                    k=0;
                }
                if (k==list2.Count) return SublistType.Superlist;
            }
        }
        return SublistType.Unequal;
    }
}