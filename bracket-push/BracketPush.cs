using System;
using System.Collections.Generic;

public static class BracketPush
{
    public static bool IsPaired(string input)
    {
        Stack<char> bracketStack = new Stack<char>();
        for (int i=0;i<input.Length;i++)
        {
            char c = input[i];
            switch (c) {
                case '(':
                case '[':
                case '{':
                    bracketStack.Push(c);
                    break;
                case ')':
                case ']':
                case '}':
                    try {
                        char x = bracketStack.Pop();
                        if (c!=x+1 && c!=x+2) return false;
                    }
                    catch {
                        return false;
                    }
                    break;
                default:
                    continue;
            }
        }
        return bracketStack.Count==0;
    }
}
