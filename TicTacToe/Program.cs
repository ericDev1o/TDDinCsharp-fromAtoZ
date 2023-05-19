TicTacToe.Game game = new TicTacToe.Game();
Console.WriteLine(game.GameToString());
short player = 1;
short index = 0;
string? move = "c";
while(game.CheckWin() == TicTacToe.WinState.GameOngoing)
{
    if(player % 2 == 0)
        Console.WriteLine("player 2 you can play:"); 
    else
        Console.WriteLine("player 1 you can play:");
    Console.WriteLine("Which board square? From 0 top left to 9 bottom right through 2 top right, 3 middle left...");
    short.TryParse(Console.ReadLine(), out index);
    Console.WriteLine("Which move? [c] cross or [z] zero?");
    move = Console.ReadLine();
    while(move != "c" && move !="z")
    {
        Console.WriteLine("Press c or z (cross or zero)");
        move = Console.ReadLine();
    }
    game.MakeMove(index, TicTacToe.Helpers.GameHelper.MatchEnteredMoveToMove(move));
    game.GameToString();
    player++;
}
Console.WriteLine(game.CheckWin() + " wins");