using System;
using System.Collections.Generic;

public static class VariableLengthQuantity
{
    public static uint[] Encode(uint[] numbers)
    {
        List<uint> encoded = new List<uint>();

        return encoded.ToArray();
    }

    public static uint[] Decode(uint[] bytes)
    {
        List<uint> result = new List<uint>();
        for (int i=0;i<bytes.Length;i++)
        {
            if ((bytes[i]>>7)%2==0 && i<bytes.Length-1) throw new InvalidOperationException();
            if ((bytes[i]>>7)%2==1 && i==bytes.Length-1) throw new InvalidOperationException();
            result += Math.Pow(128, bytes.Length-1-i) * bytes[1];
        }
        return new uint[] { result };
    }
}