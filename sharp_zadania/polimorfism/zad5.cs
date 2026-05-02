namespace sharp_zadania.polimorfism;

/// Porównaj z podejściem dziedziczenia
/// no tu opisujesz ze jakas klasa musi pelnic cos,
/// a w dziedziczeniu tworzysz klase na podstawie juz czegos stworzonego


public interface IPlatable
{
    void Oplac();
}

public class Faktura : IPlatable
{
    public void Oplac()
    {
        Console.WriteLine("cos zostalo oplacone");
    }
}

public class Paragon : IPlatable
{
    public void Oplac()
    {
        Console.WriteLine("cos zostalo oplacone");
    }
}
