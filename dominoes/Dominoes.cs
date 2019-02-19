using System;
using System.Collections.Generic;

public static class Dominoes
{
    private static bool chainRecursive(List<(int, int)> solutionPieces, List<(int,int)> remainingPieces)
    {
        bool canChain=false;
        for (int i=0;i<remainingPieces.Count;i++)
        {
            if (solutionPieces.Count==0) {
                List<(int,int)> newRemainingPieces = remainingPieces.GetRange(0,i);
                newRemainingPieces.AddRange(remainingPieces.GetRange(i+1,remainingPieces.Count-i-1));
                List<(int,int)> newSolution = new List<(int, int)>();
                newSolution.Add(remainingPieces[i]);
                canChain |= chainRecursive(newSolution, newRemainingPieces);
                newSolution = new List<(int, int)>();
                newSolution.Add((remainingPieces[i].Item2,remainingPieces[i].Item1));
                canChain |= chainRecursive(newSolution, newRemainingPieces);
            }
            else {
                bool reverse=false;
                if (solutionPieces[solutionPieces.Count-1].Item2 != remainingPieces[i].Item1) {
                    if (solutionPieces[solutionPieces.Count-1].Item2 != remainingPieces[i].Item2) continue;
                    reverse=true;
                }
                List<(int, int)> newSolution = solutionPieces.GetRange(0, solutionPieces.Count);
                if (reverse==false) 
                {
                    newSolution.Add(remainingPieces[i]);
                }
                else 
                {
                    newSolution.Add((remainingPieces[i].Item2,remainingPieces[i].Item1));
                }
                List<(int,int)> newRemainingPieces = remainingPieces.GetRange(0,i);
                newRemainingPieces.AddRange(remainingPieces.GetRange(i+1,remainingPieces.Count-i-1));
                canChain |= chainRecursive(newSolution, newRemainingPieces);
            }
        }
        if (remainingPieces.Count==0) {
            if (solutionPieces.Count==0) return true;
            return solutionPieces[0].Item1==solutionPieces[solutionPieces.Count-1].Item2;
        }
        return canChain;
    }
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        return chainRecursive(new List<(int,int)>(), new List<(int,int)>(dominoes));
    }
}