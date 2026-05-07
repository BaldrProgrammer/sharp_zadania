using sharp_zadania.wyjatki;

namespace sharp_zadania;

class ProgramWyjatki
{
    public static void Main()
    {
        //////////////////// 1111111111111111111111
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
        
        
        ///////////////////// 22222222222222222222222
        
    }
}