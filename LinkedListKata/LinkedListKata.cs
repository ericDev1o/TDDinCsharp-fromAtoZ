namespace LinkedListKata;
/*
<summary>
    This class is a LinkedList with:
        Enumeration:
            Current returns the first,
            Next moves to the next without returning
        First, Last
        Add First and Last
        Remove First and Last
</summary>
*/
public class LinkedListKata<T> : ILinkedList<T>
{
    public short CurrentIdx { get{ return CurrentIdx;} set {} }
    public List<T> MyList { get; }
    public LinkedListKata()
    {
        MyList = new List<T>();
        CurrentIdx = 0;
    }
    public bool IsEmpty()
    {
        return MyList.Count == 0;
    }
    public T First()
    {
        return MyList[0];
    }
    public T Last()
    {
        return MyList[MyList.Count - 1];
    }
    public void AddFirst(T item)
    {
        List<T> MyListAdded = new List<T>{item};
        MyListAdded.AddRange(MyList);
    }
    public void AddLast(T item)
    {
        MyList.Add(item);
    }
    public void RemoveFirst()
    {
        MyList.RemoveAt(0);
    }
    public void RemoveLast()
    {
        MyList.RemoveAt(MyList.Count - 1);
    }
    public T Current()
    {
        return MyList[CurrentIdx];
    }
    public void Next()
    {
        CurrentIdx++;
    }
}