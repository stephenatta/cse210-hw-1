public class Cycling : Activity
{
    private double _speed;  // speed provided in mph

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        // Distance = speed * (duration / 60)
        return _speed * Duration / 60.0;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        if (distance == 0)
            return 0;
        return (double)Duration / distance;
    }
}
