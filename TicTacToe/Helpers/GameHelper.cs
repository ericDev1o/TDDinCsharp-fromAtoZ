namespace TicTacToe.Helpers;
public class GameHelper
{
    /*
    <summary>
        This helper is used in Game.CheckWinner.
    </summary>
    <returns>
        The winner: Crosses or Zeroes.
    </returns>
    */
    public static WinState CheckHorizontalLineHelper(Game game)
    {
        if (game.GetState(0) == game.GetState(1) && game.GetState(1) == game.GetState(2))
            return MatchStateToWinState(game.GetState(0));
        else if (game.GetState(3) == game.GetState(4) && game.GetState(4) == game.GetState(5))
            return MatchStateToWinState(game.GetState(3));   
        else if(game.GetState(6) == game.GetState(7) && game.GetState(7) == game.GetState(8))
            return MatchStateToWinState(game.GetState(6));
        else return WinState.GameOngoing;
    }
    /*
    <summary>
        This helper is used in Game.CheckWinner.
    </summary>
    <returns>
        True if a vertical line has the same state.
    </returns>
    */
    public static WinState CheckVerticalLineHelper(Game game)
    {
        if (game.GetState(0) == game.GetState(3) && game.GetState(3) == game.GetState(6))
            return MatchStateToWinState(game.GetState(0));
        else if (game.GetState(1) == game.GetState(4) && game.GetState(4) == game.GetState(7))
            return MatchStateToWinState(game.GetState(1));   
        else if(game.GetState(2) == game.GetState(5) && game.GetState(5) == game.GetState(8))
            return MatchStateToWinState(game.GetState(2));
        else return WinState.GameOngoing;
    }
    /*
    <summary>
        This helper is used in Game.CheckWinner.
    </summary>
    <returns>
        True if a diagonal line has the same state.
    </returns>
    */
    public static WinState CheckDiagonalLineHelper(Game game)
    {
        if (game.GetState(0) == game.GetState(4) && game.GetState(4) == game.GetState(8))
            return MatchStateToWinState(game.GetState(0));
        else if (game.GetState(2) == game.GetState(4) && game.GetState(4) == game.GetState(6))
            return MatchStateToWinState(game.GetState(2));
        else return WinState.GameOngoing;
    }
    /*
    <summary>
        It matches the square's state to a winner.
    </summary>
    <param name="state">Cross or Zero</param>
    <returns>Crosses or Zeroes</returns>
    */
    public static WinState MatchStateToWinState(State state)
    {
        if(state == State.Cross)
            return WinState.Crosses;
        else if(state == State.Zero)
            return WinState.Zeroes;
        else
            return WinState.GameOngoing;
    }
    /*
    <summary>
        It matches the typed move state c or z to State.Cross orState.Zero.
    </summary>
    <param name="m">c or z</param>
    <returns>Cross or Zero</returns>
    */
    public static State MatchEnteredMoveToMove(string m)
    {
        State s = State.Unset;
        if(m == "c")
            s = State.Cross;
        else if(m == "z")
            s = State.Zero;
        return s;
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