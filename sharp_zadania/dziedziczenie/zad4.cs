namespace sharp_zadania.dziedziczenie;

public class Produkt
{
    private string _nazwa;
    private double _cena;
    
    public Produkt(string nazwa, double cena)
    {
        _nazwa = nazwa;
        _cena = cena;
    }
}


public class ProduktSpozywczy : Produkt
{
    private string _dataWaznosci;
    public ProduktSpozywczy(string nazwa, double cena, string dataWaznosci)
        :  base(nazwa, cena)
    {
        _dataWaznosci = dataWaznosci;
    }
}
