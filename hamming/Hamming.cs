using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length != secondStrand.Length)
            throw new ArgumentException();
        int hammingDistance = 0;

        for (int i=0;i<firstStrand.Length;i++)
        {
            if (firstStrand[i]!=secondStrand[i])
                hammingDistance++;
        }
        return hammingDistance;
    }
}