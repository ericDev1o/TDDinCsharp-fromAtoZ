public class CanonicalFormHelper
{
    /*
    <summary>
    Helper to capitalize a string 
    to reduce the pattern matching complexity before comparison
    </summary>
    <param name="s">string to capitalize</param>
    <returns>S the capitalized string</return>
    */
    public static string Capitalize(string s)
    {
        if(s != null) 
            return s.ToUpper();
        else return "";
    }
}