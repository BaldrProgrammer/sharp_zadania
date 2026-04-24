namespace sharp_zadania.dziedziczenie;

public class Osoba
{
    private string _imie;
    public string Imie
    {
        get => _imie;
        set => _imie = value;
    }
    
    private string _nazwisko;
    public string Nazwisko
    {
        get => _nazwisko;
        set => _nazwisko = value;
    }
    
    private string _pesel;
    public string Pesel
    {
        get => _pesel;
        set => _pesel = value;
    }

    public Osoba(string imie, string nazwisko, string pesel)
    {
        _imie = imie;
        _nazwisko = nazwisko;
        _pesel = pesel;
    }
}

public class Student : Osoba
{
    private string _nrIndeksu;
    public string NrIndeksu
    {
        get => _nrIndeksu;
        set => _nrIndeksu = value;
    }
    
    public Student(string imie, string nazwisko, string pesel, string nrIndeksu)
        : base(imie, nazwisko, pesel)
    {
        _nrIndeksu = nrIndeksu;
    }
}

public class Pracownik : Osoba
{
    private string _praca;
    public string Praca
    {
        get => _praca;
        set => _praca = value;
    }
    
    public Pracownik(string imie, string nazwisko, string pesel, string praca)
        : base(imie, nazwisko, pesel)
    {
        _praca = praca;
    }
}
