namespace ImmutableStackKata.Tests;
/*
<summary>
    Basically the tests are inspired from the mutable stack implementation.
    Memory usage is meant to be limited in terms of variable creation while 
    the state history use case isn't obvious for now.
</summary>
*/
public class ImmutableStackKataTest
{
    [Test]
    public void IsEmpty_EmptyStack_ReturnsTrue()
    {
        /// Arrange
        ImmutableStackKata<short> immutableStackKata = new ImmutableStackKata<short>();
        /// Act
        /// Assert
        Assert.IsTrue(immutableStackKata.MyStack.Count == 0);
        Assert.IsTrue(immutableStackKata.IsEmpty());
    }
    [Test]
    public void Peek_EmptyStack_ThrowsException()
    {
        /// Arrange
        ImmutableStackKata<short> immutableStackKata = new ImmutableStackKata<short>();
        /// Act
        /// Assert
        Assert.Throws<InvalidOperationException>(() => immutableStackKata.Peek());
    }
    [Test]
    public void Pop_EmptyStack_ThrowsException()
    {
        /// Arrange
        ImmutableStackKata<short> immutableStackKata = new ImmutableStackKata<short>();
        /// Act
        /// Assert
        Assert.Throws<InvalidOperationException>(() => immutableStackKata.Pop());
    }
    [Test]
    public void Push2ItemsPeek1_EmptyStack_PeekReturnsLastInsertedItem()
    {
        /// Arrange
        IStack<short> immutableStackKata = new ImmutableStackKata<short>();
        /// Act
        immutableStackKata = immutableStackKata.Push(1);
        immutableStackKata = immutableStackKata.Push(2);
        short peeked = immutableStackKata.Peek();
        /// Assert
        Assert.IsFalse(immutableStackKata.IsEmpty());
        Assert.That(peeked, Is.EqualTo(2));
    }
    [Test]
    public void Push1ItemPop1_EmptyStack_IsEmptyReturnsTrue()
    {
        /// Arrange
        IStack<short> immutableStackKata = new ImmutableStackKata<short>();
        /// Act
        immutableStackKata = immutableStackKata.Push(1);
        immutableStackKata = immutableStackKata.Pop();
        /// Assert
        Assert.IsTrue(immutableStackKata.IsEmpty());
        Assert.That(immutableStackKata.MyStack.Count, Is.EqualTo(0));
    }
}