namespace Sticks;
/*
<summary>
    The sticks game is a stick picking game.
    The loser is the one who picks the last stick.
</summary>
*/
public class Game
{
    public List<Stick> sticks { get; }
    public Player? PlayedLast { get; set;}
    public Game(short numberOfSticks)
    {
        if(numberOfSticks < 2)
            throw new ArgumentException("There must be at least 2 sticks to play the game.");
        else
        {
            sticks = new List<Stick>();
            for(short s = 0; s < numberOfSticks; s++)
            {
                sticks.Add(new Stick());
            }
            Console.WriteLine(String.Concat("The game is started. ", ToString()));
        }
    }
    /*
    <summary>
        From the game's sight sticks are removed when a player picks them.
        This method is used in Player.PickStick method.
        The number of sticks is checked at Player.PickStick level.
    </summary>
    <param name="numberOfSticks">
        The sticks picked by a player left the game.
    </param>
    */
    public void Play(short numberOfSticks)
    {
        if(numberOfSticks <= sticks.Count)
        {
            for(short s = 0; s < numberOfSticks; s++)
            {
                sticks.Remove(sticks.ElementAt(s));
            }
        }
    }
    /*
    <summary>
        This method is used to return the loser: the last who picked a stick,
        following rule 1.
    </summary>
    <returns>The last player who played</returns>
    */
    public Player? ReturnLastPlayer()
    {
        return PlayedLast;
    }
    /*
    <summary>
        Following rule 1, the only rule, the game is finished when the last stick is picked.
    </summary>
    <returns>True is returned if no stick is left in the game.</returns>
    */
    public bool CkeckThatGameIsFinished()
    {
        if(sticks.Count == 0 && PlayedLast != null)
            return true;
        else return false;
    }
    public override string ToString()
    {
        if(sticks.Count>1)
            return String.Concat("There are ", sticks.Count," sticks left in the game.");
        else if(sticks.Count == 1)
            return String.Concat("There is ", sticks.Count, " stick left in te game");
        else
            return String.Concat("There's no stick left in the game.");
    }
}