namespace RomanNumberParser.Tests;
/*
<summary>
    This class checks the RomanNumberParser.Parse() method
</summary>
*/
public class RomanParserTests
{
    RomanParser _romanNumberParser;
    public RomanParserTests()
    {
        _romanNumberParser = new RomanParser();
    }
    /*
    <summary>
        The test cases of SUT RomanNumberParser.ParseWitch() are limited to
            multiples of 5
            exceptional case multiple of 5 - 1 f.ex. 9 is IX is not handeled
        It asserts that the correct decimal number is returned by the parser.
    </summary>
    <param name="romanNum">For ex. I</param>
    <param name="decimalNum">For ex. 1</param>
    */
    [TestCase('I',1)]
    public void RomanNumberParseSwitch_OK(char romanNum, int decimalNum)
    {
        // Arrange
        // Act
        int res = _romanNumberParser.ParseSwitch(romanNum);
        // Assert
        Assert.That(res, Is.EqualTo(decimalNum));
    }
    /*
    <summary>
        The test cases of SUT RomanNumberParser.ParseForLoop() are limited to
            multiples of 5
            exceptional case multiple of 5 - 1 f.ex. 9 i.e.IX
        It asserts that the correct decimal number is returned by the parser.
    </summary>
    <param name="romanNum">For ex. I</param>
    <param name="decimalNum">For ex. 1</param>
    */
    [TestCase("I", 1)]
    [TestCase("IV", 4)]
    [TestCase("VII", 7)]
    [TestCase("IX", 9)]
    public void RomanNumberParseForLoop_OK(string romanNum, int decimalNum)
    {
        // Arrange
        // Act
        int res = _romanNumberParser.ParseForLoop(romanNum);
        // Assert
        Assert.That(res, Is.EqualTo(decimalNum));
    }
}