namespace TicTacToe;
/*
<summary>
    A board's cell can only have three states:
        - Unset at the beginning of the game,
        - Cross when the player who plays crosses filled it,
        - Zero when the player who plays zeroes filled it.
</summary>
*/
public enum State
{
    Cross,
    Zero,
    Unset
}