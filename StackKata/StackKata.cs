namespace StackKata;
/*
<summary>
    This is a reimplementation of a classical stack.
</summary>
*/
public class StackKata
{
    public List<short> Stack { get; internal set;}
    public int Counter { get; internal set;}
    public StackKata()
    {
        Stack = new List<short>();
        Counter = 0;
    }
    /*
    <summary>
        This method checks if the stack contains no element.
    </summary>
    <returns>
        It returns true in this case
    </returns>
    */
    public bool IsEmpty()
    {
        return Counter == 0;
    }
    /*
    <summary>
        This method adds an element at the end of the stack.
    </summary>
    <param name="element">
        The element is added in the LIFO data structure.
    </param>
    */
    public void Push(short element)
    {
        Stack.Add(element);
        Counter++;
    }
    /*
    <summary>
        This method removes an element from the end of the stack.
        The last inserted element is removed from the LIFO data structure.
    </summary>
    <exception cref="InvalidOperationException">
        To remove an item the stack must'nt be empty.
    </exception>
    */
    public void Pop()
    {
        if(IsEmpty())
            throw new InvalidOperationException("To pop from the stack it must contain at least 1 element.");
        else
        {
            Stack.RemoveAt(Counter - 1);
            Counter--;
        }
    }
    /*
    <summary>
        This method returns an element from the end of the stack.
        The last inserted element is returned from the LIFO data structure.
    </summary>
    <returns>
        The last inserted element is returned.
    </returns>
    <exception cref="InvalidOperationException">
        To return an item the stack must'nt be empty.
    </exception>
    */
    public short Peek()
    {
        if(IsEmpty())
            throw new InvalidOperationException("To peek from the stack it must contain at least 1 element.");
        else
        {
            return Stack[Counter - 1];
        }
    }
}