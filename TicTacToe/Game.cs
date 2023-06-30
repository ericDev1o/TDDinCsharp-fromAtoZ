namespace TicTacToe;
using System.Text;
/*
<summary>
    The TicTacToe game is a 1 vs 1 game played on a 3 by 3 square board.
    The winner is the one who made a 3 squares line either horizontal, vertical or diagonal.
    One of the player writes crosses, the other zeroes.
    Each player plays one symbol written at a time in turn.
</summary>
*/
public class Game
{
    public short MoveCounter{ get; private set;} = 0;
    public State[] Board {get; private set;} = new State[9];
    public bool Win {get; private set;} = false;
    public Game()
    {
        for(int i=0; i<9; i++)
        {
            Board[i] = State.Unset;
        }
    }
    /*
    <summary>
        This getter returns the state of a board's square given its index.
    </summary>
    <returns>
        Unset, Zero or Cross.
    </returns>
    <param name="index">board square to get the state.</param>
    */
    public State GetState(short index)
    {
        if(index < 0 || index > 8)
        {
            throw new ArgumentOutOfRangeException
            (
                "The index in the 3*3 TicTacToe square must be between 1 and 9"
            );
        }
        else return Board[index];
    }
    /*
    <summary>
        MakeMove makes a move in the square on the specified index.
        It increments the move counter.
    </summary>
    <exception cref="ArgumentOutOfRange">
         It is thrown if the index is not in a 3*3 grid i.e. not between 1 and 9 included.
    </exception>
    <param name="squareIndex">square on the board where the move is done</param>
    <param name="state">move made on the square: cross or zero</param>
    */
    public void MakeMove(short squareIndex, State state)
    {
        if(squareIndex < 0 || squareIndex > 8)
        {
            throw new ArgumentOutOfRangeException
            (
                "The index in the 3*3 TicTacToe square must be between 1 and 9"
            );
        }
        else
        {
            if(GetState(squareIndex) != State.Unset)
                throw new InvalidOperationException
                (
                    "The square cannot've been played before. It must be unset."
                );
            else
            {
                MoveCounter++;
                Board[squareIndex] = state;
            }
        }
    }
    /*
    <summary>
        This checker returns the winner(crosses or zeroes) in all winning configurations.
    </summary>
    <returns>
        Zeroes or Crosses if played 
        - by the same player
        - on a line:
            - vertical
            - horizontal
            - diagonal
        else GameOngoing
    </returns>
    */
    public WinState CheckWin()
    {
        WinState result = GameHelper.CheckHorizontalLineHelper(this);
        if(result != WinState.GameOngoing)
            return result;
        else
        {
            result = GameHelper.CheckVerticalLineHelper(this);
            if(result != WinState.GameOngoing)
                return result;
            else
            {
                result = GameHelper.CheckDiagonalLineHelper(this);
                if(result != WinState.GameOngoing)
                    return result;
                else
                    return WinState.GameOngoing;
            }
        }
    }
    /*
    <summary>
        This method prints a visualization of the board.
    </summary>
    */
    public string GameToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(" ___ ___ ___ ");
        for(int i = 0; i<9; i+=3)
        {
            sb.AppendLine
            (
                $"| {GameHelper.SquareToString(Board[i])} | {GameHelper.SquareToString(Board[i+1])} | {GameHelper.SquareToString(Board[i+2])} |"
            );
            sb.AppendLine(" ___ ___ ___");
        }
        return sb.ToString();
    }
}