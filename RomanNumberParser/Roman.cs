namespace RomanNumberParser;
/*
<summary>
    This class implementsthe data structure with the roman-decimal number matching.
<summary>
*/
public class Roman
{
    public readonly static Dictionary<string, int> RomanDecimalMapping = 
    new Dictionary<string, int>()
    {
        {"I", 1},
        {"IV", 4},
        {"V", 5},
        {"VI", 6},
        {"IX", 9},
        {"X", 10},
        {"XI", 11},
        {"IL", 49},
        {"L", 50},
        {"LI", 51},
        {"IC", 99},
        {"C", 100},
        {"CI", 101},
        {"IM", 999},
        {"M", 1000},
        {"MI", 1001}
    };
}