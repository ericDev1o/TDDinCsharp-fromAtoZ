namespace StackKata.Tests;
[TestFixture]
public class StackKataTest
{
    [Test]
    public void IsEmpty_EmptyStack_ReturnsTrue()
    {
        // Arrange
        StackKata stackKata = new StackKata();
        /// Act
        /// Assert
        Assert.IsTrue(stackKata.IsEmpty());
    }
    [Test]
    public void Count_Pushed1Element_Returns1()
    {
        // Arrange
        StackKata stackKata = new StackKata();
        short toAdd = 1;
        /// Act
        stackKata.Push(toAdd);
        /// Assert
        Assert.IsFalse(stackKata.IsEmpty());
        Assert.That(stackKata.Counter, Is.EqualTo(1));
    }
    [Test]
    public void Pop_EmptyStack_ThrowsException()
    {
         // Arrange
        StackKata stackKata = new StackKata();
        /// Act
        /// Assert
        Assert.IsTrue(stackKata.IsEmpty());
        Assert.Throws<InvalidOperationException>(() => stackKata.Pop());
    }
    [Test]
    public void Count_Popped1Element_ReturnsCounterMinus1()
    {
        // Arrange
        StackKata stackKata = new StackKata();
        short toAdd = 1;
        stackKata.Push(toAdd);
        /// Act
        stackKata.Pop();
        /// Assert
        Assert.IsTrue(stackKata.IsEmpty());
        Assert.That(stackKata.Counter, Is.EqualTo(0));
    }
    [Test]
    public void Peek_EmptyStack_ThrowsException()
    {
         // Arrange
        StackKata stackKata = new StackKata();
        /// Act
        /// Assert
        Assert.IsTrue(stackKata.IsEmpty());
        Assert.Throws<InvalidOperationException>(() => stackKata.Peek());
    }
    [Test]
    public void Peek_Pushed2Element_ReturnsTheLastPushedElement()
    {
        // Arrange
        StackKata stackKata = new StackKata();
        short toAdd = 1;
        short toAdd2 = 2;
        stackKata.Push(toAdd);
        stackKata.Push(toAdd2);
        /// Act
        short s = stackKata.Peek();
        /// Assert
        Assert.IsFalse(stackKata.IsEmpty());
        Assert.That(stackKata.Counter, Is.EqualTo(2));
        Assert.That(s, Is.EqualTo(toAdd2));
    }
    [Test]
    public void Peek_Pushed2ElementPop_ReturnsTheFirstPushedElement()
    {
        // Arrange
        StackKata stackKata = new StackKata();
        short toAdd = 1;
        short toAdd2 = 2;
        stackKata.Push(toAdd);
        stackKata.Push(toAdd2);
        stackKata.Pop();
        /// Act
        short s = stackKata.Peek();
        /// Assert
        Assert.IsFalse(stackKata.IsEmpty());
        Assert.That(stackKata.Counter, Is.EqualTo(1));
        Assert.That(s, Is.EqualTo(toAdd));
    }
}