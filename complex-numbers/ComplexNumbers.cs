using System;

public struct ComplexNumber
{
    private double _Real;
    private double _Imaginary;
    public ComplexNumber(double real, double imaginary)
    {
        this._Real = real;
        this._Imaginary = imaginary;
    }

    public double Real()
    {
        return this._Real;
    }

    public double Imaginary()
    {
        return this._Imaginary;
    }

    public ComplexNumber Mul(ComplexNumber other)
    {
        double a = this._Real;
        double b = this._Imaginary;
        double c = other.Real();
        double d = other.Imaginary();
        double real = a*c - b*d;
        double imaginary = a*d + b*c;
        return new ComplexNumber(real, imaginary);
    }

    public ComplexNumber Add(ComplexNumber other)
    {
        double real = this._Real + other.Real();
        double imaginary = this._Imaginary + other.Imaginary();
        return new ComplexNumber(real, imaginary);
    }

    public ComplexNumber Sub(ComplexNumber other)
    {
        double real = this._Real - other.Real();
        double imaginary = this._Imaginary - other.Imaginary();
        return new ComplexNumber(real, imaginary);
    }

    public ComplexNumber Div(ComplexNumber other)
    {
        double a = this._Real;
        double b = this._Imaginary;
        double c = other.Real();
        double d = other.Imaginary();
        double real = (a*c+b*d)/(c*c+d*d);
        double imaginary = (b*c - a*d)/(c*c+d*d);

        return new ComplexNumber(real, imaginary);
    }

    public double Abs()
    {
        return Math.Sqrt(this._Real*this._Real + this._Imaginary*this._Imaginary);
    }

    public ComplexNumber Conjugate()
    {
        return new ComplexNumber(this._Real, -this._Imaginary);
    }
    
    public ComplexNumber Exp()
    {
        double a = this._Real;
        double b = this._Imaginary;
        double fact = Math.Pow(Math.E, a);
        double real = fact * Math.Cos(b);
        double imaginary = fact * Math.Sin(b);
        return new ComplexNumber(real, imaginary);
    }
}