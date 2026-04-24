using sharp_zadania.dziedziczenie;

Osoba osoba = new Osoba("marek",  "kowalski", "75675674676");
Student student = new Student("ivan",  "ivanov", "3457698976856", "8767843");
Pracownik pracownik = new Pracownik("hans",  "schneider", "79098566865", "bomj");


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
