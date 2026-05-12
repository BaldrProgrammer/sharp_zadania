namespace sharp_zadania.wyjatki;

public class zad4
{
    /// throw e resetuje ślad stosu (więc błędy będą pochodzić z HandleException)
    /// throw nie - pierwotny sprawca zostałby zachowany.
    public zad4()
    {
        try
        {
            int a = 5;
            Console.WriteLine(a / 0);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}