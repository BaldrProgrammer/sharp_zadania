namespace sharp_zadania.dziedziczenie;

public class Figura
{
    public virtual void Pole()
    {
        Console.WriteLine("to nie jest figura konkretna");
    }
}


public class Kolo : Figura
{
    private int _radius;
    public Kolo(int valRadius)
    {
        _radius = valRadius;
    }
    
    public override void Pole()
    {
        Console.WriteLine($"Pole: {3.1415 * (_radius * _radius)}");
    }
}

public class Trojkat : Figura
{
    private int _strona;
    private int _wysokosc;
    public Trojkat(int valStrona, int valWysokosc)
    {
        _strona = valStrona;
        _wysokosc = valWysokosc;
    }
    
    public override void Pole()
    {
        Console.WriteLine($"Pole: {0.5 * _strona * _wysokosc}");
    }
}

public class Prostokat : Figura
{
    private int _strona1;
    private int _strona2;
    public Prostokat(int valStrona1, int valStrona2)
    {
        _strona1 = valStrona1;
        _strona2 = valStrona2;
    }
    
    public override void Pole()
    {
        Console.WriteLine($"Pole: {_strona1 * _strona2}");
    }
}
