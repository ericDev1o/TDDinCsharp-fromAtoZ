namespace Threading;
public class UpdateableSpin
{
    private readonly object _lockObj = new object();
    private bool _shouldWait = true;
    private long _executionStartingTime;
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
    public void UpdateTimeout()
    {
        lock(_lockObj)
        {
            _executionStartingTime = DateTime.UtcNow.Ticks;
        }
    }
}