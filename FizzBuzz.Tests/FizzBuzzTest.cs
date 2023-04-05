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
    FizzBuzzExercise _fizzBuzzExercise;

    //[Setup]
    public void Setup()
    {
        _fizzBuzzExercise = new FizzBuzzExercise();
    }
    /*
    <summary>Tests that FizzBuzz(3) returns "Fizz"</summary>
    <param name="number">number to test FizzBuzz under</param>
    */
    [TestCase("Fizz",3)]
    [TestCase("Fizz",-9)]
    public void FizzBuzz_isDivisibleBy3(string expected, int number)
    {
        // Arrange 
        FizzBuzz.FizzBuzzExercise testfizzbuzz = new FizzBuzzExercise();
        // Act
        // Assert
        Assert.That(testfizzbuzz.FizzBuzz(number), Is.EqualTo(expected));
    }
    /*
    <summary>Tests that FizzBuzz(5) returns "Buzz"</summary>
    <param name="number">number to test FizzBuzz under</param>
    */
    [TestCase("Buzz",5)]
    [TestCase("Buzz",-10)]
    public void FizzBuzz_isDivisibleBy5(string expected, int number)
    {
        // Arrange 
        FizzBuzz.FizzBuzzExercise testfizzbuzz = new FizzBuzzExercise();
        // Act
        // Assert
        Assert.That(testfizzbuzz.FizzBuzz(number), Is.EqualTo(expected));
    }
    /*
    <summary>Tests that FizzBuzz(8) returns "FizzBuzz"</summary>
    <param name="number">number to test FizzBuzz under</param>
    */
    [TestCase("finish",8)]
    [TestCase("finish",64)]
    [TestCase("finish",-8)]
    public void FizzBuzz_isDivisibleBy8(string expected, int number)
    {
        // Arrange 
        FizzBuzz.FizzBuzzExercise testfizzbuzz = new FizzBuzzExercise();
        // Act
        // Assert
        Assert.That(testfizzbuzz.FizzBuzz(number), Is.EqualTo(expected));
    }
    /*
    <summary>Tests that FizzBuzz(other than 3 or 5 or 8) returns ""</summary>
    <param name="number">number to test FizzBuzz under</param>
    */
    [TestCase("",-11)]
    [TestCase("",97)]
    public void FizzBuzz_isDivisibleByOtherThan3or5or8(string expected, int number)
    {
        // Arrange 
        FizzBuzz.FizzBuzzExercise testfizzbuzz = new FizzBuzzExercise();
        // Act
        // Assert
        Assert.That(testfizzbuzz.FizzBuzz(number), Is.EqualTo(expected));
    }
     /*
    <summary>Tests that FizzBuzz(0) returns "FizzBuzzFinish"</summary>
    <param name="number">number to test FizzBuzz under</param>
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
    <param name="number">number to test FizzBuzz under</param>
    */
    [TestCase("",300000001)]
    [TestCase("",-300000001)]
    public void FizzBuzz_isDivisibleByLargeValue(string expected, int number)
    {
        // Arrange 
        FizzBuzz.FizzBuzzExercise testfizzbuzz = new FizzBuzzExercise();
        // Act
        // Assert
        Assert.That(testfizzbuzz.FizzBuzz(number), Is.EqualTo(expected));
    }
}