using System;

public static class AtbashCipher
{
    public static string Encode(string plainValue)
    {
        string result = "";
        int numberOfSpaces = 0;
        foreach (char c in plainValue.ToLower())
        {
            if (c >= '0' && c <= '9') {
                result += c;
            } else {
                if (c < 'a' || c>'z') continue;
                else result += (char)(2*'a' + 25 - c);
            }
            if ((result.Length - numberOfSpaces)%5==0) {
                result += " ";
                numberOfSpaces++;
            }
        }
        return result.Trim();
    }

    public static string Decode(string encodedValue)
    {
        string result = "";
        foreach (char c in encodedValue.ToLower())
        {
            if (c >= '0' && c <= '9') {
                result += c;
                continue;
            }
            if (c<'a' || c>'z') continue;
            result += (char)(2*'a' + 25 - c);
        }
        return result;
    }
}
