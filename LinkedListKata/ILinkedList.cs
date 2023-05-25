namespace LinkedListKata;
/*
<summary>
    LinkedList is the 
    same as the stack with current and next enumeration 
    added to first and last add-remove.
</summary>
*/
public interface ILinkedList<T>
{
    /*
    <summary>
        The first implementation is open to modification.
        It'll maybe be changed in a private LinkedListKata _current. 
    </summary>
    */
    short CurrentIdx { get; internal set; }
    public List<T> MyList { get; }
    public bool IsEmpty();
    public T First();
    public T Last();
    public void AddFirst(T item);
    public void AddLast(T item);
    public void RemoveFirst();
    public void RemoveLast();
    public T Current();
    public void Next();
}