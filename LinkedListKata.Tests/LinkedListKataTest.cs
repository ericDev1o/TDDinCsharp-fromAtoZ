namespace LinkedListKata.Tests;
/*
<summary>
    The linked list links the last and first elements.
    It adds first, adds last, removes first, removes last and enumerates.
</summary>
*/
public class LinkedListTest
{
    /*
    <summary>
        The IsEmpty method is as Stack's and ImmutableStack's.
    </summary>
    */
    [Test]
    public void IsEmpty_EmptyList_ReturnsTrue()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
        // Act Assert
        Assert.IsTrue(linkedListKata.IsEmpty());
    }
    [Test]
    public void First_EmptyList_ThrowsException()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
        // Act Assert
        Assert.Throws<InvalidOperationException>(() => linkedListKata.First());
    }
    [Test]
    public void Last_EmptyList_ThrowsException()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
        // Act Assert
        Assert.Throws<InvalidOperationException>(() => linkedListKata.Last());
    }
    [Test]
    public void Last_2itemsList_ReturnsLast()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
        // Act 
        char itemLast = linkedListKata.Last();
        // Assert
        Assert.That(itemLast, Is.EqualTo(linkedListKata.MyList[linkedListKata.MyList.Count - 1]));
    }
    [Test]
    public void First_2itemsList_ReturnsFirst()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
        // Act 
        char itemFirst = linkedListKata.First();
        // Assert
        Assert.That(itemFirst, Is.EqualTo(linkedListKata.MyList[0]));
    }
    [Test]
    public void AddFirst_EmptyList_CountEquals1()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
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
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
        char itemFirstBeforeAdding = linkedListKata.First();
        // Act
        linkedListKata.AddFirst('a');
        char itemFirst = linkedListKata.First();
        // Assert
        Assert.AreNotEqual(itemFirst, itemFirstBeforeAdding);
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
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
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
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
        char itemLastBeforeAdding = linkedListKata.Last();
        // Act
        linkedListKata.AddFirst('a');
        char itemLast = linkedListKata.First();
        // Assert
        Assert.AreNotEqual(itemLast, itemLastBeforeAdding);
    }
    [Test]
    public void RemoveFirst_EmptyList_CountEquals1()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
        int countBeforeRemoval = linkedListKata.MyList.Count;
        // Act
        int count = linkedListKata.MyList.Count;
        // Assert
        Assert.That(count, Is.EqualTo(countBeforeRemoval - 1));
    }
    [Test]
    public void RemoveFirst_EmptyList_RemovedAtTheBeginning()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
        char itemFirstBeforeRemoval = linkedListKata.First();
        // Act
        linkedListKata.RemoveFirst();
        char itemFirst = linkedListKata.First();
        // Assert
        Assert.AreNotEqual(itemFirst, itemFirstBeforeRemoval);
    }
    [Test]
    public void RemoveLast_EmptyList_CountEquals1()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
        int countBeforeRemoval = linkedListKata.MyList.Count;
        // Act
        linkedListKata.RemoveFirst();
        int count = linkedListKata.MyList.Count;
        // Assert
        Assert.That(count, Is.EqualTo(countBeforeRemoval - 1));
    }
    [Test]
    public void RemoveLast_EmptyList_RemovedAtTheEnd()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
        char itemLastBeforeRemoval = linkedListKata.Last();
        // Act
        linkedListKata.RemoveLast();
        char itemLast = linkedListKata.Last();
        // Assert
        Assert.AreNotEqual(itemLast, itemLastBeforeRemoval);
    }
    [Test]
    public void RemoveFirst_EmptyList_ThrowsException()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
        // Act
        // Assert
        Assert.Throws<InvalidOperationException>(() => linkedListKata.RemoveFirst());
    }
    [Test]
    public void RemoveLast_EmptyList_ThrowsException()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
        // Act
        // Assert
        Assert.Throws<InvalidOperationException>(() => linkedListKata.RemoveLast());
    }
    [Test]
    public void EnumeratesCurrent_EmptyList_ThrowsException()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
        // Act Assert
        Assert.Throws<InvalidOperationException>(() => linkedListKata.Current());
    }
    [Test]
    public void EnumeratesNext_EmptyList_ThrowsException()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
        // Act Assert
        Assert.Throws<InvalidOperationException>(() => linkedListKata.Next());
    }
    [Test]
    public void EnumeratesCurrent_2itemsList_ReturnesFirstAndSecondInARow()
    {
        // Arrange
        ILinkedList<char> linkedListKata = new LinkedListKata<char>();
        // Act 
        linkedListKata.AddFirst('a');
        linkedListKata.AddFirst('b');
        char item = linkedListKata.Current();
        // Assert
        Assert.That(item, Is.EqualTo('a'));
        linkedListKata.Next();
        item = linkedListKata.Current();
        Assert.That(item, Is.EqualTo('b'));
    }
}