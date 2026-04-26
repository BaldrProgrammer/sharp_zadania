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
        
    }
}
