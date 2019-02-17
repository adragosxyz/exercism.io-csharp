using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string result = "";
        for (int i=0;i<text.Length;i++)
        {
            if (text[i] >= 'A' && text[i] <= 'Z')
                result += (char)('A' + ((text[i]-'A') + shiftKey)%26);
            else if (text[i] >= 'a' && text[i] <= 'z')
                result += (char)('a' + ((text[i]-'a') + shiftKey)%26);
            else 
                result += text[i];
        }
        return result;
    }
}