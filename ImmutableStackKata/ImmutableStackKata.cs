namespace ImmutableStackKata;
/*
<summary>
    This stack is immutable. 
    A modification of its underlying structure returns a new immutable stack object.
    This version doesn't use the head element attribute for simplicity.
    It may be added later on for performance comparison.
</summary>
*/
public class ImmutableStackKata<T> : IStack<T>
{
    /*
    <summary>
        The list is chosen prior to the array for its supplementary manipulation methods.
        An alternate T[] may be tried later on for performance matters.
    </summary>
    */
    public List<T> MyStack { get; internal set;}
    /*
    <summary>
        Despite code similarity, the logical unique empty immutable stack object is 
        kept for it's inherent to the immutability.
    </summary>
    */
    public EmptyStack Empty { get; }
    public ImmutableStackKata()
    {
        MyStack = new List<T>();
        Empty = new EmptyStack();
    }
    public ImmutableStackKata(List<T> stack)
    {
        MyStack = stack;
        Empty = new EmptyStack();
    }
    public sealed class EmptyStack : IStack<T>
    {
        public List<T> MyStack { get; }
        public EmptyStack()
        {
            MyStack = new List<T>();
        }
        public IStack<T> Push(T item)
        {
            return new ImmutableStackKata<T>(new List<T>());
        }
        public IStack<T> Pop()
        {
            throw new InvalidOperationException();
        }
        public T Peek()
        {
            throw new InvalidOperationException();
        }
        public bool IsEmpty() => true;
    } 
    /*
    <summary>
        Push adds an item on top of the LIFO stack.
    </summary>
    */
    public IStack<T> Push(T item)
    {
        if(MyStack != null)
        {
            MyStack.Add(item);
        }
        else
        {
            MyStack = new List<T>{item};
        }
        return new ImmutableStackKata<T>(MyStack);
    }
    /*
    <summary>
        Pop removes the pushed item. It removes it instead of peek returning it.
    </summary>
    */
    public IStack<T> Pop()
    {
        if(IsEmpty())
            throw new InvalidOperationException("The Stack must'nt be empty to Peek the last inserted item.");
        else
        {
            MyStack.Remove(MyStack.ElementAt(MyStack.Count - 1));
            return new ImmutableStackKata<T>();
        }
    }
    /*
    <summary>
        Peek returns the pushed item. It is the last added on top item.
    </summary>
    */
    public T Peek()
    {
        if(IsEmpty())
            throw new InvalidOperationException("The Stack must'nt be empty to Peek the last inserted item.");
        else
        {
            T item = MyStack[MyStack.Count - 1];
            return item;
        }
    }
    /*
    <summary>
        The IsEmpty method used in the mutable stack implementation 
        is kept for pop and peek robustness.
    </summary>
    */
    public bool IsEmpty()
    {
        return MyStack.Count == 0;
    }
}