using System;

public class SpaceAge
{
    private int seconds;
    private const double earth_value = 365.25 * 24 * 60 * 60;
    private const double mercury_value = 0.2408467 * earth_value;
    private const double venus_value = 0.61519726 * earth_value;
    private const double mars_value = 1.8808158 * earth_value;
    private const double jupiter_value = 11.862615 * earth_value;
    private const double saturn_value = 29.447498 * earth_value;
    private const double uranus_value = 84.016846 * earth_value;
    private const double neptune_value = 164.79132 * earth_value;
    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
    {
        return this.seconds / earth_value;
    }

    public double OnMercury()
    {
        return this.seconds / mercury_value;
    }

    public double OnVenus()
    {
        return this.seconds / venus_value;
    }

    public double OnMars()
    {
        return this.seconds / mars_value;
    }

    public double OnJupiter()
    {
        return this.seconds / jupiter_value;
    }

    public double OnSaturn()
    {
        return this.seconds / saturn_value;
    }

    public double OnUranus()
    {
        return this.seconds / uranus_value;
    }

    public double OnNeptune()
    {
        return this.seconds / neptune_value;
    }
}