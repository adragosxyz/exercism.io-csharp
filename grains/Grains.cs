using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n<1 || n>64) throw new ArgumentOutOfRangeException("Argument is not in range");
        ulong result = 1;
        n = n-1;
        ulong x = 2;
        while (n>0)
        {
            if (n%2==1) {
                result = result*x; 
                n = n-1;
            }
            x = x*x;
            n/=2;
        }
        return result;
    }

    public static ulong Total()
    {
        ulong result = 0;
        ulong inc = 1;
        for (int i=0;i<64;i++)
        {
            result += inc;
            inc *= 2;
        }
        return result;
    }
}