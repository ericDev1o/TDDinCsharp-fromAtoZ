// Arrange
LinkedListKata.ILinkedList<char> linkedListKata = new LinkedListKata.LinkedListKata<char>();
// Act 
linkedListKata.AddFirst('a');
linkedListKata.AddFirst('b');
char item = linkedListKata.Current();
// Assert
Console.WriteLine(item);
linkedListKata.Next();
item = linkedListKata.Current();
Console.WriteLine(item);