using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength==0) throw new ArgumentException("Slice length can't be 0");
        if (sliceLength<0) throw new ArgumentException("Slice length can't be negative");
        if (sliceLength>numbers.Length) throw new ArgumentException("Slice length greater than length of sequence");
        List<string> result = new List<string>(); 
        for (int i=0;i<=numbers.Length-sliceLength;++i)
        {
            string sequence = "";
            for (int j=i;j<i+sliceLength;j++)
            {
                sequence+=numbers[j];
            }
            result.Add(sequence);
        }
        return result.ToArray();
    }
}