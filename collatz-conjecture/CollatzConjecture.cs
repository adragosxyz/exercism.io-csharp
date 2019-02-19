using System;

public static class CollatzConjecture
{
    private static int getSteps(int number)
    {
        if (number==1) return 0;
        if (number%2==0)
        {
            return 1+getSteps(number/2);
        }
        else 
        {
            return 1+getSteps(3*number+1);
        }
    }
    public static int Steps(int number)
    {
        if (number<1) throw new ArgumentException("The number must be positive");
        return getSteps(number);
    }
}