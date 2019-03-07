using System;
using System.Collections.Generic;

public static class WordCount
{
    public static IDictionary<string, int> CountWords(string phrase)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        string[] words = phrase.Split(new char [] {'!','&','@','$','%','^',' ','\n','.',',',':'}, StringSplitOptions.RemoveEmptyEntries);
        foreach (string w in words)
        {
            string word = w.ToLower().Trim('\'');
            if (dic.ContainsKey(word)) dic[word]++;
            else dic[word]=1;
        }
        return dic;
    }
}