string s = "TDDinC#fromAtoZ";
string argumentException = "No string to canonicalize.";
try
{
    Console.WriteLine(CanonicalForm.CanonicalFormHelper.Capitalize_EFA(s));
    Console.WriteLine(CanonicalForm.CanonicalFormHelper.Capitalize_EFO(s));
    Console.WriteLine(CanonicalForm.CanonicalFormHelper.Capitalize_EFO_Linq(s));
}
catch(ArgumentNullException e)
{
    Console.WriteLine(string.Join(e.Message, ": ",argumentException));
}
catch(ArgumentException e)
{
    Console.WriteLine(string.Join(e.Message, ": ",argumentException));
}