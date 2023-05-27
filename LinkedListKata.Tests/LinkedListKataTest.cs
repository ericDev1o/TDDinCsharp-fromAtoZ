namespace LinkedListKata.Tests;
/*
<summary>
    The linked list links the last and first elements.
    It adds first, adds last, removes first, removes last and enumerates.
</summary>
*/
[TestFixture]
public class LinkedListTest
{
    private ILogger _logger = new LoggerDummy();
    /*
    <summary>
        The IsEmpty method is as Stack's and ImmutableStack's.
    </summary>
    */
    [Test]
    public void IsEmpty_EmptyList_ReturnsTrue()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        // Act Assert
        Assert.IsTrue(linkedListKata.IsEmpty());
    }
    [Test]
    public void First_EmptyList_ThrowsException()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        // Act Assert
        Assert.Throws<InvalidOperationException>(() => linkedListKata.First());
    }
    [Test]
    public void Last_EmptyList_ThrowsException()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        // Act Assert
        Assert.Throws<InvalidOperationException>(() => linkedListKata.Last());
    }
    [Test]
    public void FirstAndLast_1itemList_AreSame()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        linkedListKata.AddLast('a');
        // Act 
        // Assert
        Assert.That(linkedListKata.First(), Is.EqualTo(linkedListKata.Last()));
    }
    [Test]
    public void Last_2itemsList_ReturnsLast()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        linkedListKata.AddLast('a');
        linkedListKata.AddLast('b');
        // Act 
        char itemLast = linkedListKata.MyList[linkedListKata.MyList.Count - 1];
        // Assert
        Assert.That(itemLast, Is.EqualTo(linkedListKata.Last()));
    }
    [Test]
    public void First_2itemsList_ReturnsFirst()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        linkedListKata.AddFirst('b');
        linkedListKata.AddFirst('a');
        // Act 
        char itemFirst = linkedListKata.MyList[0];
        // Assert
        Assert.That(itemFirst, Is.EqualTo(linkedListKata.First()));
    }
    [Test]
    public void AddFirst_EmptyList_CountEquals1()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        int countBeforeAdding = linkedListKata.MyList.Count;
        // Act
        linkedListKata.AddFirst('a');
        int count = linkedListKata.MyList.Count;
        // Assert
        Assert.That(count, Is.EqualTo(countBeforeAdding + 1));
    }
    /*
    <summary>
        First means zero index.
    </summary>
    */
    [Test]
    public void AddFirst_EmptyList_AddedAtTheBeginning()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        linkedListKata.AddFirst('b');
        char itemFirstBeforeAdding = linkedListKata.First();
        // Act
        linkedListKata.AddFirst('a');
        char itemFirst = linkedListKata.First();
        // Assert
        Assert.That(itemFirst, Is.Not.EqualTo(itemFirstBeforeAdding));
    }
    /*
    <summary>
        Last means count-1 index.
    </summary>
    */
    [Test]
    public void AddLast_EmptyList_CountEquals1()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        int countBeforeAdding = linkedListKata.MyList.Count;
        // Act
        linkedListKata.AddLast('a');
        int count = linkedListKata.MyList.Count;
        // Assert
        Assert.That(count, Is.EqualTo(countBeforeAdding + 1));
    }
    [Test]
    public void AddLast_EmptyList_AddedAtTheEnd()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        linkedListKata.AddLast('b');
        char itemLastBeforeAdding = linkedListKata.Last();
        // Act
        linkedListKata.AddLast('a');
        char itemLast = linkedListKata.Last();
        // Assert
        Assert.That(itemLast, Is.Not.EqualTo(itemLastBeforeAdding));
    }
    [Test]
    public void RemoveFirst_1itemList_CountEquals0()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        linkedListKata.AddFirst('a');
        int countBeforeRemoval = linkedListKata.MyList.Count;
        // Act
        linkedListKata.RemoveFirst();
        int count = linkedListKata.MyList.Count;
        // Assert
        Assert.That(count, Is.EqualTo(countBeforeRemoval - 1));
    }
    [Test]
    public void RemoveFirst_2itemsList_RemovedAtTheBeginning()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        linkedListKata.AddFirst('a');
        linkedListKata.AddFirst('b');
        char itemFirstBeforeRemoval = linkedListKata.First();
        // Act
        linkedListKata.RemoveFirst();
        char itemFirst = linkedListKata.First();
        // Assert
        Assert.That(itemFirst, Is.Not.EqualTo(itemFirstBeforeRemoval));
    }
    [Test]
    public void RemoveLast_1itemList_CountEquals0()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        linkedListKata.AddLast('a');
        int countBeforeRemoval = linkedListKata.MyList.Count;
        // Act
        linkedListKata.RemoveLast();
        int count = linkedListKata.MyList.Count;
        // Assert
        Assert.That(count, Is.EqualTo(countBeforeRemoval - 1));
    }
    [Test]
    public void RemoveLast_2itemsList_RemovedAtTheEnd()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        linkedListKata.AddLast('b');
        linkedListKata.AddLast('a');
        char itemLastBeforeRemoval = linkedListKata.Last();
        // Act
        linkedListKata.RemoveLast();
        char itemLast = linkedListKata.Last();
        // Assert
        Assert.That(itemLast, Is.Not.EqualTo(itemLastBeforeRemoval));
    }
    [Test]
    public void RemoveFirst_List_ThrowsException()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        // Act
        // Assert
        Assert.Throws<InvalidOperationException>(() => linkedListKata.RemoveFirst());
    }
    [Test]
    public void RemoveLast_EmptyList_ThrowsException()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        // Act
        // Assert
        Assert.Throws<InvalidOperationException>(() => linkedListKata.RemoveLast());
    }
    [Test]
    public void EnumeratesCurrent_EmptyList_ThrowsException()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        // Act Assert
        Assert.Throws<InvalidOperationException>(() => linkedListKata.Current());
    }
    [Test]
    public void EnumeratesNext_EmptyList_ThrowsException()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        // Act Assert
        Assert.Throws<InvalidOperationException>(() => linkedListKata.Next());
    }
    /*
    <summary>
        Checks that at the last item's index, 
        Next() moves the pointer to the first item.
    </summary>
    */
    [Test]
    public void EnumeratesCurrent_2itemsList_ReturnesFirstAndSecondAndFirstInARow()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>(_logger);
        char[] content = new char[]{'a','b'};
        foreach(char c in content)
        {
            linkedListKata.AddLast(c);
        }
        // Act 
        char item = linkedListKata.Current();
        // Assert
        for(short s = 0; s<3; s++)
        {
            Assert.That(item, Is.EqualTo(content[s%2]));
            linkedListKata.Next();
            item = linkedListKata.Current();
        }
    }
}