namespace sharp_zadania.dziedziczenie;

public interface IPrintable
{
    void Drukuj();
}

public class Dokument : IPrintable
{
    private string _tytul;
    public Dokument(string tytul)
    {
        _tytul = tytul;
    }

    public void Drukuj()
    {
        Console.WriteLine($"Dokument {_tytul} zostal rozdrukowany");
    }
}
