using System;
using System.Collections.Generic;

public static class VariableLengthQuantity
{
    public static uint[] Encode(uint[] numbers)
    {
        List<uint> encoded = new List<uint>();
        foreach (uint number in numbers)
        {
            List<uint> tmp = new List<uint>();
            uint nr = number & 127;
            int shift = 1;
            tmp.Add(nr);
            do {
                nr = (number>>(7*shift)) & 127;
                tmp.Add(128 + nr);
                shift++;
            } while(shift<=4);

            tmp.Reverse();
            bool firstIsNot0 = false;
            for(int i=0;i<tmp.Count;i++)
            {
                if (tmp[i]!=128) firstIsNot0=true;
                if (firstIsNot0==false && tmp[i]==128){
                    continue;
                }
                else {
                    encoded.Add(tmp[i]);
                }
            }
        }
        return encoded.ToArray();
    }

    public static uint[] Decode(uint[] bytes)
    {
        List<uint> result = new List<uint>();
        uint rezultat=0;
        for (int i=0;i<bytes.Length;i++)
        {
            if ((((int)bytes[i] & 128) == 128) && i==bytes.Length-1) throw new InvalidOperationException("Invalid sequence");
            rezultat = rezultat<<7;
            if (bytes[i]<128)
            {
                rezultat += bytes[i];
                result.Add(rezultat);
                rezultat=0;
            }
            else {
                rezultat += (bytes[i]-128);
            }
        }
        return result.ToArray();
    }
}