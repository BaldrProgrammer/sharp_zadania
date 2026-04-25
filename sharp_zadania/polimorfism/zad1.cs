namespace sharp_zadania.polimorfism;

class Zwierz
{
    public virtual void Dzwiek()
    {
        Console.WriteLine("Dzwiek");
    }
}

class Kot : Zwierz
{
    public override void Dzwiek()
    {
        Console.WriteLine("Kot wydal dzwiek");
    }
}

class Pies : Zwierz
{
    public override void Dzwiek()
    {
        Console.WriteLine("Pies wydal dzwiek");
    }
}