using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        string nr = number.ToString();
        int final=0;
        for (int i=0;i<nr.Length;i++)
        {
            final += (int)Math.Pow(nr[i]-'0', nr.Length);
        }
        return final==number;
    }
}