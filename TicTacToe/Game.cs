namespace TicTacToe;
using System.Text;
public class Game
{
    public static short MoveCounter{ get; private set;} = 0;
    public State[] Board {get; private set;} = new State[9];
    public bool Win {get; private set;} = false;
    public Game()
    {
        for(int i=1; i < 10; i++)
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
        if(index < 1 || index > 9)
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
        if(squareIndex < 1 || squareIndex > 9)
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
        This checker returns true in all winning configurations.
    </summary>
    <returns>
        true if zeroes or crosses are played 
        - by the same player
        - on a line:
            - vertical
            - horizontal
            - diagonal
        else false
    </returns>
    */
    public bool CheckWin()
    {
        if
        (
            //vertical zeroes
            (
                GetState(1)==State.Zero 
                && GetState(4)==State.Zero 
                && GetState(7)==State.Zero
            ) ||
            (
                GetState(2)==State.Zero 
                && GetState(5)==State.Zero 
                && GetState(8)==State.Zero
            ) ||
            (
                GetState(3)==State.Zero 
                && GetState(6)==State.Zero 
                && GetState(9)==State.Zero
            ) ||
            // horizontal crosses
            (
                GetState(1)==State.Zero 
                && GetState(2)==State.Zero 
                && GetState(3)==State.Zero
            ) ||
            (
                GetState(4)==State.Zero 
                && GetState(5)==State.Zero 
                && GetState(6)==State.Zero
            ) ||
            (
                GetState(7)==State.Zero 
                && GetState(8)==State.Zero 
                && GetState(9)==State.Zero
            ) ||
            // diagonal zeroes
            (
                GetState(1)==State.Zero 
                && GetState(5)==State.Zero 
                && GetState(9)==State.Zero
            ) ||
            (
                GetState(3)==State.Zero 
                && GetState(5)==State.Zero 
                && GetState(7)==State.Zero
            ) ||
            // vertical crosses
            (
                GetState(1)==State.Cross 
                && GetState(4)==State.Cross 
                && GetState(7)==State.Cross
            ) ||
            (
                GetState(2)==State.Cross 
                && GetState(5)==State.Cross 
                && GetState(8)==State.Cross
            ) ||
            (
                GetState(3)==State.Cross 
                && GetState(6)==State.Cross 
                && GetState(9)==State.Cross
            ) ||
            // horizontal crosses
            (
                GetState(1)==State.Cross 
                && GetState(2)==State.Cross 
                && GetState(3)==State.Cross
            ) ||
             (
                GetState(4)==State.Cross 
                && GetState(5)==State.Cross 
                && GetState(6)==State.Cross
            ) ||
            (
                GetState(7)==State.Cross 
                && GetState(8)==State.Cross 
                && GetState(9)==State.Cross
            ) ||
            // diagonal crosses
            (
                GetState(1)==State.Cross 
                && GetState(5)==State.Cross 
                && GetState(9)==State.Cross
            ) ||
             (
                GetState(3)==State.Cross 
                && GetState(5)==State.Cross 
                && GetState(7)==State.Cross
            )
        )
        {
           return true;
        }
        else return false;
    }
    /*
    <summary>
        This method prints a visualization of the board.
    </summary>
    */
    public void GameToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(" ___ ___ ___ ");
        for(int i = 0; i<10; i+=3)
        {
            sb.AppendLine
            (
                $"| {GameHelper.SquareToString(Board[i])} | {GameHelper.SquareToString(Board[i+1])} | {GameHelper.SquareToString(Board[i+2])} |"
            );
        }
        sb.AppendLine(" ___ ___ ___");
    }
}