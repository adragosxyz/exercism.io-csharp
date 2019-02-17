using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        string[] tmp = Colors();
        for (int i=0;i<tmp.Length;i++)
        {
            if (tmp[i]==color.ToLower())
                return i;
        }
        return -1;
    }

    public static string[] Colors()
    {
        return new string[10] {
            "black",
            "brown",
            "red",
            "orange",
            "yellow",
            "green",
            "blue",
            "violet",
            "grey",
            "white"
        };
    }
}