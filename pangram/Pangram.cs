using System;
using System.Collections.Generic;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        List<char> list = new List<char>();
        foreach (char c in input)
        {
            char final_c = c;
            if (final_c<'a') final_c=(char)(final_c+32);
            if (final_c>='a' && final_c<='z' && !list.Contains(final_c)) list.Add(final_c);
        }
        return list.Count==26;
    }
}
