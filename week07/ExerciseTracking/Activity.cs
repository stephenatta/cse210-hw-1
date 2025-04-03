using System;

public abstract class Activity
{
    private DateTime _date;
    private int _duration;  // in minutes

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public DateTime Date { get { return _date; } }
    public int Duration { get { return _duration; } }

    // Abstract methods to be overridden by derived classes
    public abstract double GetDistance();  // in miles
    public abstract double GetSpeed();     // in mph
    public abstract double GetPace();      // minutes per mile

    // Virtual method to produce a summary string; can be overridden if needed
    public virtual string GetSummary()
    {
        string dateStr = Date.ToString("dd MMM yyyy");
        return $"{dateStr} {this.GetType().Name} ({Duration} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
