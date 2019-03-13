using System.Collections.Generic;
using System;

public class Anagram
{
    private string BaseWord;
    private int[] FrequencyVector;
    public Anagram(string baseWord)
    {
        this.BaseWord = baseWord.ToLower();
        this.FrequencyVector = new int[26];
        foreach (char c in this.BaseWord)
        {
            if (c<'a' || c>'z') continue;
            FrequencyVector[(int)c-'a']++;   
        }
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        List<string> results = new List<string>();
        foreach (string potentialMatch in potentialMatches)
        {
            if (potentialMatch.ToLower()==this.BaseWord) continue;
            int[] potentialFrequencyVector = (int[])this.FrequencyVector.Clone();
            bool good = true;
            foreach (char c in potentialMatch.ToLower())
            {
                if (c<'a' || c>'z') {good=false; break;}
                potentialFrequencyVector[(int)c-'a']--;
                if (potentialFrequencyVector[(int)c-'a']<0) {good=false; break;}
            }
            for (int i=0;i<26;i++)
            {
                if (potentialFrequencyVector[i]!=0) good=false;
            }
            if (good == true)
                results.Add(potentialMatch);
        }
        return results.ToArray();
    }
}