namespace sharp_zadania.wyjatki;

class BladBiznesowy : Exception
{
    public BladBiznesowy(string message) 
        : base(message) { }
    
    public BladBiznesowy(string message, Exception inner) 
        : base(message, inner) { }
}

class BladWalidacji : BladBiznesowy
{
    public BladWalidacji(string message) 
        : base(message) { }
    
    public BladWalidacji(string message, Exception inner) 
        : base(message, inner) { }
}

class BladTransakcji : BladBiznesowy
{
    public BladTransakcji(string message) 
        : base(message) { }
    
    public BladTransakcji(string message, Exception inner) 
        : base(message, inner) { }
}
