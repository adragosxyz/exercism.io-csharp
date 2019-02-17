using System;

public static class Bob
{
    public static string Response(string statement)
    {
        if (statement.Trim().Length==0) {
            return "Fine. Be that way!";
        }
        else if(statement.Trim()[statement.Trim().Length-1] == '?' && statement.ToUpper() == statement && statement.ToLower() != statement) {
            return "Calm down, I know what I'm doing!";
        }
        else if (statement.ToUpper() == statement && statement.ToLower() != statement) {
            return "Whoa, chill out!";
        }
        else if(statement.Trim()[statement.Trim().Length-1] == '?') {
            return "Sure.";
        }
        else return "Whatever.";
    }
}