namespace FizzBuzz.Tests;
/*
<summary>
    This class tests a simple FizzBuzz divisible by 3,5,8 implementation exercise.
    Boundary is 
        0 = all divisibility,
        large under integer 32 limit = 300000001 (300Million1 under 3Billion1). 
        1 is to avoid divisibility by 3 and 5. Boundary is at a 10 times precision.
</summary>
*/
[TestFixture]
public class FizzBuzzTests
{
    /*
    <summary>Tests that FizzBuzz(3) returns "Fizz"</summary>
    */
    [Test]
    public void FizzBuzz_isDivisibleBy3()
    {
        // Arrange 
        FizzBuzz.FizzBuzzExercise testfizzbuzz = new FizzBuzzExercise();
        // Act
        // Assert
        Assert.That(testfizzbuzz.FizzBuzz(9), Is.EqualTo("Fizz"));
    }
    /*
    <summary>Tests that FizzBuzz(5) returns "Buzz"</summary>
    */
    [Test]
    public void FizzBuzz_isDivisibleBy5()
    {
        // Arrange 
        FizzBuzz.FizzBuzzExercise testfizzbuzz = new FizzBuzzExercise();
        // Act
        // Assert
        Assert.That(testfizzbuzz.FizzBuzz(10), Is.EqualTo("Buzz"));
    }
    /*
    <summary>Tests that FizzBuzz(8) returns "FizzBuzz"</summary>
    */
    [Test]
    public void FizzBuzz_isDivisibleBy8()
    {
        // Arrange 
        FizzBuzz.FizzBuzzExercise testfizzbuzz = new FizzBuzzExercise();
        // Act
        // Assert
        Assert.That(testfizzbuzz.FizzBuzz(64), Is.EqualTo("finish"));
    }
    /*
    <summary>Tests that FizzBuzz(other than 3 or 5 or 8) returns ""</summary>
    */
    [Test]
    public void FizzBuzz_isDivisibleByOtherThan3or5or8()
    {
        // Arrange 
        FizzBuzz.FizzBuzzExercise testfizzbuzz = new FizzBuzzExercise();
        // Act
        // Assert
        Assert.That(testfizzbuzz.FizzBuzz(97), Is.EqualTo(""));
    }
     /*
    <summary>Tests that FizzBuzz(0) returns "FizzBuzzFinish"</summary>
    */
    [Test]
    public void FizzBuzz_isDivisibleBy0()
    {
        // Arrange 
        FizzBuzz.FizzBuzzExercise testfizzbuzz = new FizzBuzzExercise();
        // Act
        // Assert
        Assert.That(testfizzbuzz.FizzBuzz(0), Is.EqualTo("FizzBuzzFinish"));
    }
     /*
    <summary>Tests that FizzBuzz(other than 3 or 5 or 8 large not too large 3M1 not 3billion1) returns ""</summary>
    */
    [Test]
    public void FizzBuzz_isDivisibleByLargeValue()
    {
        // Arrange 
        FizzBuzz.FizzBuzzExercise testfizzbuzz = new FizzBuzzExercise();
        // Act
        // Assert
        Assert.That(testfizzbuzz.FizzBuzz(300000001), Is.EqualTo(""));
    }
}