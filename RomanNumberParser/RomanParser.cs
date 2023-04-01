namespace RomanNumberParser;
/*
<summary>
    This class implements a simple roman nuùber parser.
</summary>
*/
public class RomanParser
{
    /*
    <summary>
        This method converts a roman number in the decimal value
    </summary>
    <param name="romanNum">For example I, V, X, L, C, M</param>
    <returns>Respectively 1, 5, 10, 50, 100, 1000</returns>
    */
    public int Parse(string romanNum)
    {
        switch(romanNum)
        {
            case "I":
                return 1;
            case "V":
                return 5;
            case "X":
                return 10;
            case "L":
                return 50;
            case "C":
                return 100;
            case "M":
                return 1000;
            default:
                return 0;
        }
    }
}