namespace TicTacToe.Tests;

public class Tests
{
    /*
    <summary>
        This test asserts that there's been no move at game creation.
    </summary>
    */
    [Test]
    public void CreateGame_ZeroMoves()
    {
        //Arrange
        Game game = new Game();
        //Act
        //Assert
        Assert.That(Game.MoveCounter, Is.EqualTo(0));
    }
    /*
    <summary>
        This test asserts that at game creation the board is unset.
    </summary>
    <param name="index">board index to check the unset state</param>
    */
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    [TestCase(4)]
    [TestCase(5)]
    [TestCase(6)]
    [TestCase(7)]
    [TestCase(8)]
    [TestCase(9)]
    public void CreateGame_StatesUnset(short index)
    {
        //Arrange
        Game game = new Game();
        //Act
        //Assert
        Assert.That(game.GetState(index), Is.EqualTo(State.Unset));
    }
    /*
    <summary>
        This test asserts that a move increments the move counter by 1.
    </summary>
    */
    [Test]
    public void MakeMove_MoveCounterShifts()
    {
        //Arrange
        Game game = new Game();
        int moveCounter = Game.MoveCounter;
        //Act
        game.MakeMove(1, State.Cross);
        //Assert
        Assert.That(Game.MoveCounter, Is.EqualTo(moveCounter + 1));
    }
    /*
    <summary>
        This test asserts that an invalid move throws an ArgumentOutOfRangeException..
    </summary>
    */
    [TestCase(0)]
    [TestCase(10)]
    public void MakeInvalidMove_ThrowsArgumentOutOfRangeException(short squareIndex)
    {
        //Assert
        Assert.Throws<ArgumentOutOfRangeException>
        (
            () =>
            {
                //Arrange
                Game game = new Game();
                //Act
                game.MakeMove(squareIndex, State.Cross);
            }
        );
    }
    /*
    <summary>
        This test asserts that an invalid move throws an ArgumentOutOfRangeException..
    </summary>
    */
    [TestCase(1)]
    public void MoveOnTheSameQuareTwice_ThrowsInvalidOperationException(short squareIndex)
    {
        //Assert
        Assert.Throws<InvalidOperationException>
        (
            () =>
            {
                //Arrange
                Game game = new Game();
                //Act
                game.MakeMove(squareIndex, State.Cross);
                game.MakeMove(squareIndex, State.Cross);
            }
        );
    }
    /*
    <summary>
        This test asserts that a move changes the state correctly.
    </summary>
    */
    [TestCase(State.Cross)]
    [TestCase(State.Zero)]
    public void MakingMoves_SetStateCorrectly(State state)
    {
        //Arrange
        Game game = new Game();
        //Act
        game.MakeMove(1, state);
        //Assert
        Assert.That(game.GetState(1), Is.EqualTo(state));
    }
    /*
    <summary>
        This test asserts that a vertical zeroes line wins the game.
    </summary>
    */
    public void PlayVerticalZeroesLine_WinsGame()
    {
        //Arrange
        Game game = new Game();
        //Act
        game.MakeMove(1, State.Zero);
        game.MakeMove(4, State.Zero);
        game.MakeMove(7, State.Zero);
        //Assert
        Assert.IsTrue(game.CheckWin());
    }
}