using System;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int sum = 0;
        for (int i=1;i<max;i++)
        {
            bool alreadyAdded = false;
            foreach (int multiply in multiples)
            {
                if (multiply==0) continue;
                if (i%multiply==0 && alreadyAdded==false) {
                    sum += i;
                    alreadyAdded = true;
                }
            }
        }
        return sum;
    }
}