namespace RomanNumberParser.Tests;
/*
<summary>
    This class checks the RomanNumberParser.Parse() method
</summary>
*/
public class RomanParserTests
{
    RomanParser _romanNumberParser;
    [SetUp]
    public void Setup()
    {
        _romanNumberParser = new RomanParser();
    }
    /*
    <summary>
        The test cases of SUT RomanNumberParser.Parse() are limited to
            multiples of 5
            exceptional case multiple of 5 - 1 f.ex. 9 i.e.IX
        It asserts that the correct decimal number is returned by the parser.
    </summary>
    <param name="romanNum">For ex. I</param>
    <param name="decimalNum">For ex. 1</param>
    */
    [TestCase("I",1)]
    public void RomanNumberParser_OK(string romanNum, int decimalNum)
    {
        // Arrange
        // Act
        int res = _romanNumberParser.Parse(romanNum);
        // Assert
        Assert.That(res, Is.EqualTo(decimalNum));
    }
}