namespace Sticks;
/*
<summary>
    The player picks stick(s). It removes them from the game.
</summary>
*/
public class Player
{
    public List<Stick> PickedSticks {get; internal set;}
    public string Name { get; }
    public Player(string name)
    {
        PickedSticks = new List<Stick>();
        Name = name;
    }
    /*
    <summary>
        A game's turn is over when each player picked stick(s).
    </summary>
    <param name="game">A player plays at least one game.</param>
    <param name="numberOfSticks">A player picks one or more sticks out of a game.</param>
    */
    public void PickStick(Game game, short numberOfSticks)
    {
        if(numberOfSticks <= 0 || numberOfSticks > game.sticks.Count)
            throw new ArgumentException(
                "The number of picked sticks must be a positive number less or equal than the created game's sticks number.");
        else
        {
            PickedSticks.AddRange(game.sticks.Take(numberOfSticks));
            game.Play(numberOfSticks);
            game.PlayedLast = this;
            string sticksNumber = " sticks";
            if(numberOfSticks == 1)
                sticksNumber = " stick";
            Console.WriteLine(String.Concat(Name, " picks ", numberOfSticks, sticksNumber));
        }
    }
}