namespace sharp_zadania.polimorfism;

abstract class Pracownik
{
    private int _zaplata = 5000;
    public int Zaplata
    {
        get => _zaplata;
        set => _zaplata = value;
    }
    
    public abstract double? ObliczPlace();
}

class Stazysta : Pracownik
{
    public override double? ObliczPlace()
    {
        return Zaplata * 1.2;
    }
}

class Etatowy : Pracownik
{
    public override double? ObliczPlace()
    {
        if (Zaplata >= 4666)
        {
            return Zaplata * 0.9;
        }
        return null;
    }
}

class Kontraktowy : Pracownik
{
    public override double? ObliczPlace()
    {
        return Zaplata;
    }
}