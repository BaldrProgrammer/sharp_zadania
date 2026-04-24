namespace sharp_zadania.dziedziczenie;

public class Osoba
{
    private string _imie;
    private string _nazwisko;
    private string _pesel;

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
    
    public Student(string imie, string nazwisko, string pesel, string nrIndeksu)
        : base(imie, nazwisko, pesel)
    {
        _nrIndeksu = nrIndeksu;
    }
}

public class Pracownik : Osoba
{
    private string _praca;
    
    public Pracownik(string imie, string nazwisko, string pesel, string praca)
        : base(imie, nazwisko, pesel)
    {
        _praca = praca;
    }
}
