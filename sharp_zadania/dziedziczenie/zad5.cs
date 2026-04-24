namespace sharp_zadania.dziedziczenie;

/// Porównaj z podejściem dziedziczenia
/// w dziedziczeniu tworzymy nowy klase na podstawie innej klasy,
/// tutaj uzywamy w klasie typ parametru jako inna klasa, sa to 2 rozne podejscia
///
/// Kiedy użyć czego?
/// ja uzywam dziedziczenia nprz w ORM, kiedy tworze nowe modele na podstawie jakiegos Base,
/// w ktorym beda pola ktore musza byc we wszystkich modelach, Kompozycje mozna uzywac wlasnie wtedy kiedy robimy nprz pole z ForeignKey. ja widze ta roznice w ten sposob





public class Silnik
{
    private double _pojemnosc;
    private int _moc;

    public Silnik(int pojemnosc, int moc)
    {
        _pojemnosc = pojemnosc;
        _moc = moc;
    }
}

public class Samochod
{
    private string _model;
    private string _marka;
    private Silnik _silnik;
    
    public Samochod(string model, string marka, Silnik silnik)
    {
        _model = model;
        _marka = marka;
        _silnik = silnik;
    }
}
