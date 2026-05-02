using sharp_zadania.polimorfism;


class ProgramPolimorfism
{
    public static void Main()
    {
        ///////////////////// 1111111111111111
        Zwierz[] zwierza =  new Zwierz[]
        {
            new Kot(),
            new Pies()
        };

        foreach (Zwierz zwierz in zwierza)
        {
            zwierz.Dzwiek();
        }
        
        
        ///////////////////// 22222222222222222
        Ksztalt[] ksztalty = new Ksztalt[]
        {
            new Kolo(5),
            new Prostokat(1, 3)
        };

        foreach (Ksztalt ksztalt in ksztalty)
        {
            Console.WriteLine(ksztalt.Pole());
            Console.WriteLine(ksztalt.Obwod());
        }
        
        
        //////////////////// 33333333333333333333
        Pracownik[] pracownicy = new Pracownik[]
        {
            new Stazysta(),
            new Etatowy(),
            new Kontraktowy()
        };
        double sumaWynagrodzen = 0;

        foreach (Pracownik pracownik in pracownicy)
        { 
            sumaWynagrodzen += pracownik.ObliczPlace() ?? 0;
        }
        Console.WriteLine(sumaWynagrodzen);
        
        
        ////////////////// 444444444444444444444
        Stos<int> stosInt =  new Stos<int>();
        stosInt.Push(1);
        stosInt.Push(2);
        stosInt.Push(3);
        stosInt.Pop();
        
        Stos<string> stosStr =  new Stos<string>();
        stosStr.Push("odin");
        stosStr.Push("dva");
        stosStr.Push("tri");
        stosStr.Pop();
    }
}
