namespace sharp_zadania.polimorfism;

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
