using System;

public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int low = 0;
        int high = input.Length-1;

        while (low<=high)
        {
            int center = low + (high-low)/2;
            if (input[center]==value) return center;
            if (input[center]<value)
            {
                low = center+1;
            }
            else
            {
                high = center-1;
            }
        }
        return -1;
    }
}