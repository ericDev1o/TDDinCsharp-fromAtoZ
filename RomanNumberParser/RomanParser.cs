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
    public int ParseSwitch(char romanNum)
    {
        switch(romanNum)
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'M':
                return 1000;
            default:
                return 0;
        }
    }
    /*
    <summary>
        This method converts a roman number in the decimal value reading it in a for loop.
        It assumes that the letters are ordered from biggest roman to smallest roman number
        with special minus cases f.ex.:MMCICIXIVIII
    </summary>
    <param name="romanNum">For example I, V, X, L, C, M</param>
    <returns>Respectively 1, 5, 10, 50, 100, 1000</returns>
    */
    public int ParseForLoop(string romanNum)
    {
        int resultAcc = 0;
        if(romanNum.Length == 1)
            resultAcc = ParseSwitch(romanNum[0]);
        else if(romanNum.Length > 1)
        {
            for(int i = 0; i < romanNum.Length-1; i++)
            {
                char c = romanNum[i];
                char cplus1 = romanNum[i+1];
                if(c == cplus1 || !(Roman.SpecialMinus1Cases.Contains(cplus1) && c == 'I'))
                    resultAcc += ParseSwitch(c);
                else if(Roman.SpecialMinus1Cases.Contains(cplus1) && c == 'I')
                {
                    resultAcc += ParseSwitch(cplus1) - 1;
                    i++;
                }
            }
            if(romanNum.Length > 2)
                resultAcc += ParseSwitch(romanNum[romanNum.Length - 1]);
        }
        return resultAcc;
    }
}