using sharp_zadania.dziedziczenie;

/////////////////////////////////// 1111111111111111111111111
Figura[] tablicaWskaznikow = new Figura[]
{
    new Kolo(1),
    new Trojkat(1, 1),
    new Prostokat(1, 1),
};


/////////////////////////////////// 22222222222222222222222222
Osoba osoba = new Osoba("marek", "kowalski", "75675674676");
Student student = new Student("ivan", "ivanov", "3457698976856", "8767843");
Pracownik pracownik = new Pracownik("hans", "schneider", "79098566865", "bomj");


Console.WriteLine($"Osoba: {osoba.Imie}");
Console.WriteLine($"Osoba: {osoba.Nazwisko}");
Console.WriteLine($"Osoba: {osoba.Pesel}\n");

Console.WriteLine($"Student: {student.Imie}");
Console.WriteLine($"Student: {student.Nazwisko}");
Console.WriteLine($"Student: {student.Pesel}");
Console.WriteLine($"Student: {student.NrIndeksu}\n");

Console.WriteLine($"Pracownik: {pracownik.Imie}");
Console.WriteLine($"Pracownik: {pracownik.Nazwisko}");
Console.WriteLine($"Pracownik: {pracownik.Pesel}");
Console.WriteLine($"Pracownik: {pracownik.Praca}\n");


/////////////////////////////////// 444444444444444444444444
Produkt produkt = new Produkt("abs", 0.0);
ProduktSpozywczy produktSpozywczy = new ProduktSpozywczy("mleko", 14.99, "24.04.26");