namespace RomanNumberParser;
/*
<summary>
    This class implements a simple roman number parser.
</summary>
*/
public class RomanParser
{
    /*
    <summary>
        This method converts a roman number in the decimal value switching each case.
    </summary>
    <param name="romanNum">For example I, V, X, L, C, M</param>
    <returns>Respectively 1, 5, 10, 50, 100, 1000</returns>
    */
    public int ParseSwitch(string romanNum)
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
    /*
    <summary>
        This method converts a roman number in the decimal value reading it in a for loop.
    </summary>
    <param name="romanNum">For example I, V, X, L, C, M</param>
    <returns>Respectively 1, 5, 10, 50, 100, 1000</returns>
    */
    public int ParseForLoop(string romanNum)
    {
        char[] specialMinus1Cases = new char[] {'V', 'X', 'C', 'M'};
        for(int i = 0; i < romanNum.Length; i++)
        {
            char c = romanNum[i];
            char cplus1 = romanNum[i+1];

            if(specialMinus1Cases.Contains(cplus1))
            {
                string specialMinus1Number = string.Concat(c, cplus1);
            }
        }
        return 0;
    }
}