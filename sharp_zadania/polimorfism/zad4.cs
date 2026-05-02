namespace sharp_zadania.polimorfism;

public class Stos<T>
{
    private List<T> _stack;

    public void Push(T item)
    {
        _stack.Insert(0, item);
    }

    public T Pop()
    {
        T element = _stack[0];
        _stack.RemoveAt(0);
        return element;
    }
}