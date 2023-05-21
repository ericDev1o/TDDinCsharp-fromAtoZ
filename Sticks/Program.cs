Sticks.Player p1 = new Sticks.Player("Winner");
Sticks.Player p2 = new Sticks.Player("Loser");
Sticks.Game game = new Sticks.Game(2);
p1.PickStick(game, 1);
p2.PickStick(game, 1);
Console.WriteLine(String.Concat("Is the game finished? ", game.CkeckThatGameIsFinished()));
Console.WriteLine(String.Concat("Who losed? ", p2.ToString(), " losed."));
Console.WriteLine(String.Concat("Game organizer, who losed? ", game.ReturnLastPlayer()?.ToString(), " losed."));