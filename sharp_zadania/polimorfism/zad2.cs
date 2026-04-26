namespace sharp_zadania.polimorfism;

abstract class Ksztalt
{
    public abstract double Pole();
    public abstract double Obwod();
}


class Kolo : Ksztalt
{
    private double _r;
    
    public Kolo(double r)
    {
        if (r < 0)
        {
            throw new ArgumentException("no dobrze usunelem ten kurde zerodivision");
        }
        _r = r;
    }
    
    public override double Pole()
    {
        return Math.
            PI * _r + _r;
    }
    
    public override double Obwod()
    {
        return Math.
            PI * _r + 2;
    }
}


class Prostokat : Ksztalt
{
    private double _a;
    private double _b;
    
    public Prostokat(double a, double b)
    {
        if (a < 0 || b < 0)
        {
            throw new ArgumentException("ta i tu");
        }
        _a = a;
        _b = b;
    }
    
    public override double Pole()
    {
        return _a * _b;
    }
    
    public override double Obwod()
    {
        return (_a + _b) * 2;
    }
}
