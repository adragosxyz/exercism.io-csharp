using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    private List<int> scores;
    private List<int> scores_sorted;
    public HighScores(List<int> list)
    {
        this.scores = list;
        this.scores_sorted = this.scores.GetRange(0, this.scores.Count);
        this.scores_sorted.Sort(
            delegate(int a, int b)
            {
                return b-a;
            }
        );
    }

    public List<int> Scores()
    {
        return this.scores;
    }

    public int Latest()
    {
        return this.scores[this.scores.Count - 1];
    }

    public int PersonalBest()
    {
        return this.scores_sorted[0];
    }

    public List<int> PersonalTop()
    {
        return this.scores_sorted.GetRange(0,(3<=this.scores.Count ? 3 : this.scores.Count));
    }

    public string Report()
    {
        int difference = this.PersonalBest()-this.Latest();
        return $"Your latest score was {this.Latest()}. That's{(difference==0 ? "" : $" {difference} short of" )} your personal best!";
    }
}