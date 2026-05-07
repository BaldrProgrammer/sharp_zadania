using sharp_zadania.wyjatki;

namespace sharp_zadania;

class ProgramWyjatki
{
    public static void Main()
    {
        try
        {
            zad1.Silnia(-45);
        }
        catch (BladSilni e)
        {
            Console.WriteLine("хуй");
        }
        catch (Exception e)
        {
            Console.WriteLine("хуй2");
        }
    }
}