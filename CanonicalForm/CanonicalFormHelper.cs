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
    public static string Capitalize_EFA(string s)
    {
        if(s != null) 
            return s.ToUpper();
        else return "";
    }
    public static string Capitalize_EFO(string s)
    {
        string resStr = "";
        if(s == null || s =="")
            return resStr;
        string[] strArray = s.Split(" ").ToArray<string>();
        IEnumerable<string> resStrArray = new string[]{};
        foreach(string st in strArray)
        {
            string capStr = st.ToUpper();
            resStrArray = resStrArray.Append(capStr);
        }
        foreach(string st in resStrArray)
        {
            resStr = resStrArray.Count() != 1 ? string.Join(resStr," ",st) : st;
        }
        return resStr;
    }
}