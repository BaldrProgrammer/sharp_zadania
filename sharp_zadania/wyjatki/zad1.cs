namespace sharp_zadania.wyjatki;

class BladSilni : Exception
{
    public BladSilni(string message) 
        : base(message) { }
    
    public BladSilni(string message, Exception inner) 
        : base(message, inner) { }
}

public class zad1
{
    public static void Silnia(int n)
    {
        if (n < 0)
        {
            throw new BladSilni("ujemna jest ta n");
        }
    }
}