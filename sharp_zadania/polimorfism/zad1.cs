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
}

public class Pies : Zwierz
{
}