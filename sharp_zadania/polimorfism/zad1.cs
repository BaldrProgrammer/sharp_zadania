namespace sharp_zadania.polimorfism;

public class Zwierz
{
    public virtual void Dzwiek()
    {
        Console.WriteLine("Dzwiek");
    }
}

public class Kot : Zwierz
{
    public override void Dzwiek()
    {
        Console.WriteLine("Kot wydal dzwiek");
    }
}

public class Pies : Zwierz
{
    public override void Dzwiek()
    {
        Console.WriteLine("Pies wydal dzwiek");
    }
}