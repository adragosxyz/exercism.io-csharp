using System;

public class Clock
{
    private int _Minutes;
    private int _Hours;
    public Clock(int hours, int minutes)
    {
        _Hours = hours;
        _Hours += minutes/60;
        _Minutes = minutes%60;
        _Hours = _Hours % 24;
        while (_Minutes<0) {
            _Hours--;
            _Minutes+=60;
        }
        while (_Hours<0) _Hours+=24;
    }

    public int Hours
    {
        get
        {
            return _Hours;
        }
    }

    public int Minutes
    {
        get
        {
            return _Minutes;
        }
    }

    public Clock Add(int minutesToAdd)
    {
        int newMinutes = this.Minutes;
        int newHours = this.Hours;
        
        newMinutes += minutesToAdd;
        newHours += newMinutes/60;
        newMinutes = newMinutes % 60;

        return new Clock(newHours, newMinutes);
    }

    public Clock Subtract(int minutesToSubtract)
    {
        int newMinutes = this.Minutes;
        int newHours = this.Hours;

        newMinutes -= minutesToSubtract;
        while (newMinutes<0)
        {
            newHours--;
            newMinutes+=60;
        }
        return new Clock(newHours, newMinutes);
    }

    public override string ToString()
    {
        return String.Format("{0:00}:{1:00}",this.Hours, this.Minutes);
    }

    public override bool Equals(object obj)
    {
        if (obj.GetType() != typeof(Clock)) return false;
        Clock clock = (Clock)obj;
        return (clock.Hours == this.Hours && clock.Minutes == this.Minutes);
    }
}