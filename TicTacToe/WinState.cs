namespace TicTacToe;
/*
<summary>
    A game can only have 4 states:
        - GameOngoing at the beginning and until at least 1 cell remains Unset,
        - Draw when no player filled 3 cells in a row horiz. or vert. or diagon.,
        - Crosses when the crosses player filled above mentioned 3 cells,
        - Zeroes when the zeroes player filled above mentioned 3 cells.
</summary>
*/
public enum WinState
{
    Crosses,
    Zeroes,
    Draw,
    GameOngoing
}