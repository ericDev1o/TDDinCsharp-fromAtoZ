namespace CanonicalForm;
/*
<summary>
    CanonicalFormHelper takes a string as input.
    It reduces it to unique way of writing it.
    The aim is to check the input string:
        - in a simpler way
        - improving the check performance
</summary>
*/
public class CanonicalFormHelper
{
    /*
    <summary>
        Helper to capitalize a string 
        to reduce the pattern matching complexity before comparison
    </summary>
    <param name="s">
        string to capitalize
    </param>
    <returns>
        S the capitalized string
    </return>
    */
    public static string Capitalize_EFA(string? s)
    {
        if(s != null) 
            return s.ToUpper();
        else return "";
    }
    /*
    <summary>
        Helper to capitalize a string 
        to reduce the pattern matching complexity before comparison
    </summary>
    <param name="s">
        string to capitalize
    </param>
    <returns>
        S the capitalized string
    </return>
    <exception cref="ArgumentNullException">
        It is thrown when the argument is null.
    </exception>
    <exception cref="ArgumentException">
        It is thrown when the argument isan empty string.
    </exception>
    */
    public static string Capitalize_EFO(string? s)
    {
        string resStr = "";
        if(s == null)
        {
            throw new ArgumentNullException("No string to canonicalize.");
        }
        if(s == "")
            throw new ArgumentException("No string to capitalize.");
        string[] strArray = s.Split(" ");
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
     /*
    <summary>
        Helper to capitalize a string 
        to reduce the pattern matching complexity before comparison
    </summary>
    <param name="s">
        string to capitalize
    </param>
    <returns>
        S the capitalized string
    </return>
    <exception cref="ArgumentNullException">
        It is thrown when the argument is null.
    </exception>
    <exception cref="ArgumentException">
        It is thrown when the argument isan empty string.
    </exception>
    */
    public static string Capitalize_EFO_Linq(string? s)
    {
        if(s == null)
            throw new ArgumentNullException();
        string resStr = "";
        short stringLengthLimit = 256;
        if(s == "")
            throw new ArgumentException();
        string sTrimmed = s.TrimStart().TrimEnd();
        if(sTrimmed == "")
            throw new ArgumentException();
        resStr = sTrimmed.TrimStart('0').Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(s => s.ToUpper()).OrderBy(s => s)
        .Where(stringInput => stringInput.Length < stringLengthLimit)
        .Aggregate("",(current,next) => current + " " + next).Trim();
        return resStr;
    }
    /*
    <summary>
        These delegates fix the NUnit2044 violation.
    </summary>
    */
    public delegate string Capitalize_EFA_delegate(string? s);
    public delegate string Capitalize_EFO_delegate(string? s);
    public delegate string Capitalize_EFO_Linq_delegate(string? s);
}