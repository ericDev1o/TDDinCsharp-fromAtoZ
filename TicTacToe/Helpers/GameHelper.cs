namespace TicTacToe.Helpers;
public class GameHelper
{
    /*
    <summary>
        This helper is used in Game.CheckWinner.
    </summary>
    <returns>
        True if a horizontal line has the same state.
    </returns>
    */
    public static bool CheckHorizontalLineHelper(Game game)
    {
        if
        (
            (game.GetState(1) == game.GetState(2) && game.GetState(2) == game.GetState(3))
            ||
            (game.GetState(4) == game.GetState(5) && game.GetState(5) == game.GetState(6))
            ||
            (game.GetState(7) == game.GetState(8) && game.GetState(8) == game.GetState(9))
        )
        return true;
        else return false;
    }
    /*
    <summary>
        This helper is used in Game.CheckWinner.
    </summary>
    <returns>
        True if a vertical line has the same state.
    </returns>
    */
    public static bool CheckVerticalLineHelper(Game game)
    {
        if
        (
            (game.GetState(1) == game.GetState(4) && game.GetState(4) == game.GetState(7))
            ||
            (game.GetState(2) == game.GetState(5) && game.GetState(5) == game.GetState(8))
            ||
            (game.GetState(3) == game.GetState(6) && game.GetState(6) == game.GetState(9))
        )
        return true;
        else return false;
    }
    /*
    <summary>
        This helper is used in Game.CheckWinner.
    </summary>
    <returns>
        True if a diagonal line has the same state.
    </returns>
    */
    public static bool CheckDiagonalLineHelper(Game game)
    {
        if
        (
            (game.GetState(1) == game.GetState(5) && game.GetState(5) == game.GetState(9))
            ||
            (game.GetState(3) == game.GetState(5) && game.GetState(5) == game.GetState(7))
        )
        return true;
        else return false;
    }
    /*
    <summary>
        This helper prints a cross or a zero or nothing depending on the square's state.
    </summary>
    */
    public static string SquareToString(State state)
    {
        switch(state)
        {
            case State.Cross:
                return "X";
            case State.Zero:
                return "0";
            case State.Unset:
                return " ";
            default:
                throw new ArgumentOutOfRangeException("The state must be either cross, zero or unset.");
        };
    }
}