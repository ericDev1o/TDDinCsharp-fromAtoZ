namespace ImmutableStackKata;
public interface IStack<T>
{
    public List<T> MyStack { get; }
    public IStack<T> Push(T value);
    public IStack<T> Pop();
    public T Peek();
    public bool IsEmpty();
}