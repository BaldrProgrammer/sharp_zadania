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
        try
        {
            int wiek = -5;

            if (wiek < 0) {
                throw new BladWalidacji("Niepoprawny wiek");
            }

            int saldo = 0;

            if (saldo == 0) {
                throw new BladTransakcji("Brak środków");
            }
        }
        catch (BladWalidacji e)
        {
            Console.WriteLine("podczas wykonania wystepil bled walidacji");
            throw;
        }
        catch (BladTransakcji e)
        {
            Console.WriteLine("podczas wykonania wystepil bled transakcji");
            throw;
        }
        
    }
}