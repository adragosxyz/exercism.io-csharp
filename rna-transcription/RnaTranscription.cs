using System;
using System.Collections.Generic;
public static class RnaTranscription
{
    public static Dictionary<char,char> RnaDictionary = new Dictionary<char, char>() {
        {'G','C'},
        {'C','G'},
        {'T','A'},
        {'A','U'}
    };
    public static string ToRna(string nucleotide)
    {
        string result = "";
        foreach (char c in nucleotide) {
            result += RnaDictionary[c];
        }
        return result;
    }
}