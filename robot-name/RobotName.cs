using System;

public static class RobotNameGenerator
{
    private static Random _rand = new Random();
    private static int[] vector = new int[] 
    {
        _rand.Next(26),
        _rand.Next(26),
        _rand.Next(10),
        _rand.Next(10),
        _rand.Next(10)
    };
    public static string GetNewName()
    {
        string name = "";
        if (vector[0]==25 && vector[1]==25 && vector[2]==9 && vector[3]==9 && vector[4]==9) {
            for (int i=0;i<vector.Length;i++)
                vector[i] = 0;
        }
        else {
            int idx = 0;
            if (vector[0]==25) {
                vector[0]=0;
                idx++;
                if (vector[1]==25) {
                    vector[1]=0;
                    idx++;
                    if (vector[2]==9) {
                        vector[2]=0;
                        idx++;
                        if (vector[3]==9) {
                            vector[3]=0;
                            idx++;
                        }
                    }
                }
            }
            ++vector[idx];
        }
        name += (char)('A' + vector[0]);
        name += (char)('A' + vector[1]);
        name += (char)('0' + vector[2]);
        name += (char)('0' + vector[3]);
        name += (char)('0' + vector[4]);
        return name;
    }
}
public class Robot
{
    private string _Name;

    public Robot()
    {
        this.Reset();
    }
    public string Name
    {
        get
        {
            return _Name;
        }
    }

    public void Reset()
    {
        _Name = RobotNameGenerator.GetNewName();
    }
}