using System;
using System.Diagnostics;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        double result = realNumber;
        return Math.Pow(result, r.Expreal());
    }
}

public struct RationalNumber
{
    public int Numerator;
    public int Denominator;
    public RationalNumber(int numerator, int denominator)
    {
        this.Numerator = numerator;
        this.Denominator = denominator;
        this.Numerator *= MathHelper.Sign(this.Denominator);
        this.Denominator *= MathHelper.Sign(this.Denominator);
        this.Reduce();
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1.Numerator*r2.Denominator + r2.Numerator*r1.Denominator, r1.Denominator*r2.Denominator);
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1.Numerator*r2.Denominator - r2.Numerator*r1.Denominator, r1.Denominator*r2.Denominator);
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1.Numerator*r2.Numerator, r1.Denominator*r2.Denominator);
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1.Numerator*r2.Denominator, r1.Denominator*r2.Numerator);
    }

    public RationalNumber Abs()
    {
        if (this.Numerator<0) this.Numerator*=-1;
        if (this.Denominator<0) this.Denominator*=-1;
        return this;
    }

    public RationalNumber Reduce()
    {
        int gcd = MathHelper.GCD(this.Numerator, this.Denominator);
        this.Numerator /= gcd;
        this.Denominator /= gcd;
        return this;
    }

    public RationalNumber Exprational(int power)
    {
        this.Numerator = (int)Math.Pow(this.Numerator, power);
        this.Denominator = (int)Math.Pow(this.Denominator, power);
        return this;
    }

    public double Expreal()
    {
        return (1.0*this.Numerator/this.Denominator);
    }
}

public static class MathHelper
{
    public static int GCD(int a, int b)
    {
        if (b==0) return a;
        return GCD(b, a%b);
    }
    public static int Sign(int a)
    {
        if (a>0) return 1;
        else if (a==0) return 0;
        else return -1;
    }
}