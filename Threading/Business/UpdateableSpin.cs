namespace Threading.Business;
/*
<summary>
    UpdateableSpin is a simple implementation of asynchronous multithreading
</summary>
*/
public class UpdateableSpin
{
    private readonly object _lockObj = new object();
    private bool _shouldWait = true;
    private long _executionStartingTime;
    /*
    <summary>
        Wait suspends the execution during a time interval.
    </summary>
    <param name="timeout">The wait time.</param>
    <param name="spinDuration">This additional time is not used in first version.<param>
    <returns>
        False as soon as the timeout is exceeded.
    </returns>
    */
    public bool Wait(TimeSpan timeout, int spinDuration = 0)
    {
        UpdateTimeout();
        while(true)
        {
            lock(_lockObj)
            {
                if(! _shouldWait)
                    return true;
                if(DateTime.UtcNow.Ticks - _executionStartingTime > timeout.Ticks)
                    return false;
            }
        }
    }
    /*
    <summary>
        Set is the _shouldWait state toggler.
        It switches to shouldn't wait if it was in should wait state.
    </summary>
    */
    public void Set()
    {
        if(_shouldWait)
        {
            lock(_lockObj)
            {
                _shouldWait = false;
            }
        }
    }
    /*
    <summary>
        UpdateTimeout is the execution start time saver.
        It'll be used to get the execution time with execution end time.
    </summary>
    */
    public void UpdateTimeout()
    {
        lock(_lockObj)
        {
            _executionStartingTime = DateTime.UtcNow.Ticks;
        }
    }
}