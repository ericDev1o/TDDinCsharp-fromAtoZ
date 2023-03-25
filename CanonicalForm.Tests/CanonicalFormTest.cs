namespace CanonicalForm.Tests;

public class Tests
{
    string _s = "";
    [SetUp]
    public void Setup()
    {
        _s = "TDDinC#fromAtoZ";
    }
    [Test]
    /*
    <summary>
    Test with Linq Split, ToUpper, Select, Aggregate
    Handle ArgumentNullException
    Think API from the start
    </summary>
    */
    public void CanonicalForm_EFO_isCapitalized()
    {
        Assert.That(CanonicalFormHelper.Capitalize_EFO(_s), Is.EqualTo("TDDINC#FROMATOZ"));
    }
    public void CanonicalForm_EFA_isCapitalized()
    {
        Assert.That(CanonicalFormHelper.Capitalize_EFA(_s), Is.EqualTo("TDDINC#FROMATOZ"));
    }
}