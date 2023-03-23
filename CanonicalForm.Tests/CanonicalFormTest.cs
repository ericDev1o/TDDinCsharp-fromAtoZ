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
    public void CanonicalForm_isCapitalized()
    {
        Assert.That(CanonicalFormHelper.Capitalize(_s), Is.EqualTo("TDDINC#FROMATOZ"));
    }
}