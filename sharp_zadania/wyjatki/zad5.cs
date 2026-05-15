namespace sharp_zadania.wyjatki;

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