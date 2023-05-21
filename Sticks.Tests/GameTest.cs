namespace Sticks.Tests;
public class GameTest
{
    [Test]
    public void PlayerWhoPicksLastStick_Loses()
    {
        /// Arrange
        Player winner = new Player("Winner");
        Player loser = new Player("Loser");
        Game game = new Game(2);
        /// Act
        winner.PickStick(game, 1);
        loser.PickStick(game, 1);
        /// Assert
        Assert.IsTrue(game.CkeckThatGameIsFinished());
        Assert.That(game.ReturnLastPlayer(), Is.SameAs(loser));
    }
}