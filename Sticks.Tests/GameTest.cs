namespace Sticks.Tests;
public class GameTest
{
    [Test]
    public void GameStartsWithLessThan2Sticks_Throws()
    {
        // Arrange Act Assert
        Assert.Throws<ArgumentException>(() => new Game(1));
    }
    [Test]
    [TestCase(0)]
    [TestCase(3)]
    public void PlayerPicksAnInvalidNumberOfSticks_Throws(short numberOfSticks)
    {
        // Arrange
        Player tester = new Player("Tester");
        Game game = new Game(2);
        /// Act Assert
        Assert.Throws<ArgumentException>
        (
            () => tester.PickStick(game, numberOfSticks)
        )
        ;
    }
    [Test]
    public void PlayerWhoPicksLastStick_Loses()
    {
        // Arrange
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