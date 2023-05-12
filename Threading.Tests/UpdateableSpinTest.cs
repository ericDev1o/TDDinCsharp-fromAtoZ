namespace Threading.Tests;

public class UpdateableSpinTest
{
    UpdateableSpin _updateableSpin;
    Stopwatch _stopwatch;
    public UpdateableSpinTest()
    {
        //Arrange
        _updateableSpin = new UpdateableSpin();
        _stopwatch = new Stopwatch();
    }

    [Test]
    public void Wait_NoPulse_ReturnsFalse()
    {
        //Arrange
        //Act
        bool wasPulsed = _updateableSpin.Wait(TimeSpan.FromMilliseconds(10));
        //Assert
        Assert.IsFalse(wasPulsed);
    }
    [Test]
    public void WaitFor50Milliseconds_ActuallyWaitsFor50Milliseconds()
    {
        //Arrange
        _stopwatch.Reset();_stopwatch.Restart();
        //Act
        _updateableSpin.Wait(TimeSpan.FromMilliseconds(50));
        _stopwatch.Stop();
        TimeSpan elapsed = TimeSpan.FromMilliseconds(_stopwatch.ElapsedMilliseconds);
        TimeSpan leftEpsilon = TimeSpan.FromMilliseconds(50-(50*0.01));
        TimeSpan rightEpsilon = TimeSpan.FromMilliseconds(50+(50*0.01));
        //Assert
        Assert.IsTrue(elapsed > leftEpsilon && elapsed < rightEpsilon);
    }
    [Test]
    public void WaitFor500Milliseconds_UpdateAfter300Milliseconds_ActuallyWaitsForApproximately800Milliseconds()
    {
        //Arrange
        _stopwatch.Reset();_stopwatch.Restart();
        const int timeout = 500;
        const int spanBeforeUpdate = 300;
        //Act
        Task.Factory.StartNew(() => {
            Thread.Sleep(spanBeforeUpdate);
            _updateableSpin.UpdateTimeout();
        });
        _updateableSpin.Wait(TimeSpan.FromMilliseconds(timeout));
        _stopwatch.Stop();
        TimeSpan elapsed = TimeSpan.FromMilliseconds(_stopwatch.ElapsedMilliseconds);
        TimeSpan leftEpsilon = TimeSpan.FromMilliseconds(800-(800*0.1));
        TimeSpan rightEpsilon = TimeSpan.FromMilliseconds(800+(800*0.1));
        //Assert
        Assert.IsTrue(elapsed > leftEpsilon && elapsed < rightEpsilon);
    }
}