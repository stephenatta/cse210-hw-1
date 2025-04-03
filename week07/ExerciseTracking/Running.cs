public class Running : Activity
{
    private double _distance;  // distance provided in miles

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        // Speed (mph) = (distance / duration) * 60
        return (_distance / Duration) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per mile) = duration / distance
        return (double)Duration / _distance;
    }
}
