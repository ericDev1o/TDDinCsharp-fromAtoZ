﻿// Arrange
LinkedListKata.ILinkedList<char> linkedListKata = 
    new LinkedListKata.LinkedListKata<char>
    (
        new LinkedListKata.Helpers.Loggers.LoggerDummy()
    );
// Act 
linkedListKata.AddFirst('a');
linkedListKata.AddFirst('b');
char item = linkedListKata.Current();
// Assert
Console.WriteLine(item);
for(short i = 0; i<2; i++)
{
    linkedListKata.Next();
    item = linkedListKata.Current();
    Console.WriteLine(item);
}
string path = Path.Combine
(
    Directory.GetCurrentDirectory(), 
    @"Helpers\Loggers\Logs\Log.txt"
);
File.AppendAllText(path, string.Concat("test", Environment.NewLine));