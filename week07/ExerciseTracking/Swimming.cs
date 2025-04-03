public class Swimming : Activity
{
    private int _laps;  // number of laps

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Distance (miles) = laps * 50 / 1000 * 0.62
        return _laps * 50.0 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        // Speed (mph) = (distance / duration) * 60
        return (GetDistance() / Duration) * 60;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        if (distance == 0)
            return 0;
        return (double)Duration / distance;
    }
}
