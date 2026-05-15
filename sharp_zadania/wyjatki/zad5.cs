namespace sharp_zadania.wyjatki;

/// W C++ zasob zwolnisz natychmiast gdy obiekt opuszcza klamry kodu bo kompilator sam wywoluje destruktor.
/// W C# pamiecia rządzi Garbage Collector wiec musisz uzyc jawnego bloku using ktory wywola metode Dispose.
/// W C++ mechanizm RAII dziala automatycznie dla zmiennych na stosie.
/// W C# musisz sam pamietac o dopisaniu using inaczej zasob pozostanie otwarty do nieokreslonego momentu sprzatania przez system.

public class Zasob : IDisposable
{
    private string _dbUrl;
    
    public Zasob(string dbUrl)
    {
        _dbUrl = dbUrl;
        Console.WriteLine($"Zasob bazy {_dbUrl}");
    }

    public void Wykorzystac()
    {
        Console.WriteLine($"wykorzystane jest {_dbUrl}");
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }
    
    ~Zasob(){
        Console.WriteLine($"Zasob zniszczony");
    }
}