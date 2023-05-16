TicTacToe.Game game = new TicTacToe.Game();
game.MakeMove(1, TicTacToe.State.Cross);
Console.WriteLine(TicTacToe.Game.MoveCounter);
game.GameToString();
while(! game.CheckWin())
{
    short index = 0;
    short.TryParse(Console.ReadLine(), out index);
    game.MakeMove(index, TicTacToe.State.Cross);
}