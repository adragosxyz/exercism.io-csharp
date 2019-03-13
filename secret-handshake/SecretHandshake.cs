using System;
using System.Collections.Generic;

public static class SecretHandshake
{
    private static readonly Dictionary<int, string> CommandCodes = new Dictionary<int, string>
    {
        { 0b1, "wink" },
        { 0b10, "double blink" },
        { 0b100, "close your eyes" },
        { 0b1000, "jump" },
        { 0b10000, "Reverse" }
    };
    public static string[] Commands(int commandValue)
    {
        List<string> commands = new List<string>();
        foreach (KeyValuePair<int, string> kvp in CommandCodes)
        {
            if ((kvp.Key&commandValue)!=0)
            {
                if (kvp.Value!="Reverse") commands.Add(kvp.Value);
                else commands.Reverse();
            }
        }
        return commands.ToArray();
    }
}
