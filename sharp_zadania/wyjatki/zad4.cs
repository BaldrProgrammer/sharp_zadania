namespace sharp_zadania.wyjatki;

public class zad4
{
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