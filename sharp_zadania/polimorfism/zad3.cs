namespace sharp_zadania.polimorfism;

abstract class Pracownik
{
    public abstract double ObliczPlace();
}

class Stazysta : Pracownik
{
    public override double ObliczPlace()
    {
        return  1.5;
    }
}

class Etatowy : Pracownik
{
    public override double ObliczPlace()
    {
        return  1.5;
    }
}

class Kontraktowy : Pracownik
{
    public override double ObliczPlace()
    {
        return  1.5;
    }
}