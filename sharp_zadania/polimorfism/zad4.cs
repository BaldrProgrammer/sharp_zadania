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
        if (isEmpty() == true)
        {
            throw new Exception("stack is empty");
        }
        
        int lastIndex = _stack.Count - 1;
        T element = _stack[lastIndex];
        _stack.RemoveAt(lastIndex);
        return element;
    }
    
    public bool isEmpty()
    {
        return _stack.Count == 0;
    }
}
