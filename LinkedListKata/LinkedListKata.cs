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
    /*
    <summary>
        _current is used by Current() to return the pointed element.
        _current is sequentially modified by Next().
    </summary>   
    */
    private short _current;
    //private readonly ILogger<LinkedListKata<T>> _logger;
    private readonly ILogger _logger;
    /*
    <summary>
        The List is chosen for the wider range of manipulation methods than T[].
    </summary>   
    */
    public List<T> MyList { get; internal set;}
    /*
    <summary>
        The initial LinkedList is empty pointing on the first index.
    </summary>   
    */
    public LinkedListKata(ILogger logger)
    {
        MyList = new List<T>();
        _current = 0;
        _logger = logger;
    }
    /*
    <summary>
        IsEmpty() is used to limit the typing caracters and time of this check.
    </summary>
    <returns>
        True if the LinkedList is empty.
    </returns>
    */
    public bool IsEmpty()
    {
        return MyList.Count == 0;
    }
    /*
    <summary>
        First()'s use is similar to IsEmpty.
    </summary>
    <returns>
        The first item of the LinkedList is returned.
    </returns>
    <exception cref="InvalidOperationException">
        To return an item the stack must'nt be empty.
    </exception>
    */
    public T First()
    {
        if(IsEmpty())
            throw new InvalidOperationException("To return the first item from the stack it must contain at least 1 element.");
        else
            return MyList[0];
    }
    /*
    <summary>
        See First() above for the choice that lead to implement Last().
    </summary>
    <returns>
        Returns the last item of the LinkedList.
    </returns>
    <exception cref="InvalidOperationException">
        To return an item the stack must'nt be empty.
    </exception>
    */
    public T Last()
    {
        if(IsEmpty())
            throw new InvalidOperationException("To return the last item from the stack it must contain at least 1 element.");
        else
            return MyList[MyList.Count - 1];
    }
    /*
    <summary>
        AddFirst() adds an item at the beginning of the LinkedList.
    </summary>
    <param name="item">
        The typed item to add.
    </param> 
    */
    public void AddFirst(T item)
    {
        List<T> MyListAdded = new List<T>{item};
        if(MyList.Count != 0)
            MyListAdded.AddRange(MyList);
        MyList = MyListAdded;
        _logger.LogInformation($"Added at the beginning item {item}", item);
    }
    /*
    <summary>
        AddFirst() adds an item at the beginning of the LinkedList.
    </summary>
    <param name="item">
        The typed item to add.
    </param>    
    */
    public void AddLast(T item)
    {
        MyList.Add(item);
        _logger.LogInformation($"Added at the end item {item}", item);
    }
    /*
    <summary>
        RemoveFirst removes the first, i.e. with lowest index, item.
    </summary>
    <exception cref="InvalidOperationException">
        The removal requires at least one item in the LinkedList.
    </exception>
    */
    public void RemoveFirst()
    {
        if(IsEmpty())
            throw new InvalidOperationException("To remove from the stack it must contain at least 1 element.");
        else
        {
            MyList.RemoveAt(0);
            _logger.LogInformation("Removed the item at the beginning");
        }
    }
    /*
    <summary>
        RemoveLast removes the first, i.e. with lowest index, item.
    </summary> 
    <exception cref="InvalidOperationException">
        The removal requires at least one item in the LinkedList.
    </exception>
    */
    public void RemoveLast()
    {
        if(IsEmpty())
            throw new InvalidOperationException("To remove from the stack it must contain at least 1 element.");
        else
        {
            MyList.RemoveAt(MyList.Count - 1);
            _logger.LogInformation("Removed the item at the end");
        }
    }
    /*
    <summary>
        Current() returns the currently pointed item.
    </summary>
    <returns>
        The item at index _current.
    </returns>
    <exception cref="InvalidOperationException">
        To return the currently pointed item there must be at least one item in the LinkedList.
    </exception>
    */
    public T Current()
    {
        if(IsEmpty())
            throw new InvalidOperationException("To return the current item from the stack it must contain at least 1 element.");
        else
            return MyList[_current];
    }
    /*
    <summary>
        Next() moves sequentially to the next item.
        When pointing the last it points to the first again. The link is circular.
    </summary>
    <exception cref="InvalidOperationException">
        Next() is meant to rightshift the Current() pointer to the next item.
        Being related to an item and coherent with Current 
        there must be at least one item in the LinkedList.
    </exception>
    */
    public void Next()
    {
        if(IsEmpty())
            throw new InvalidOperationException("To point to the next item from the stack it must contain at least 1 element.");
        else
        {
            if(_current == MyList.Count - 1)
                _current = 0;
            else
                _current++;
        }
    }
}