namespace sharp_zadania.dziedziczenie;

public class Figura
{
    public void Pole()
    {
        Console.WriteLine("to nie jest figura konkretna");
    }
}


public class Kolo : Figura
{
    public void Pole(int radius)
    {
        Console.WriteLine($"Pole: {3.1415 * (radius * radius)}");
    }
}

public class Trojkat : Figura
{
    public void Pole(int strona, int wysokosc)
    {
        Console.WriteLine($"Pole: {0.5 * strona * wysokosc}");
    }
}

public class Prostokat : Figura
{
    public void Pole(int strona1, int strona2)
    {
        Console.WriteLine($"Pole: {strona1 * strona2}");
    }
}
