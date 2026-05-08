namespace sharp_zadania.wyjatki;

class Plik
{
    private FileStream _fileStream;
    
    public Plik(string path)
    {
        if (File.Exists(path))
        {
            _fileStream = new FileStream(path, FileMode.Open);
        }
        else
        {
            throw new FileNotFoundException("plik nie znaleziony");
        }
    }

    ~Plik()
    {
        _fileStream.Dispose();
    }
}