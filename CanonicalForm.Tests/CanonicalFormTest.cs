namespace CanonicalForm.Tests;

public class Tests
{
    string _s = "";
    string? _s_null = null;
    delegate string _canonicalizeDelegate(string? s);
    [SetUp]
    public void Setup()
    {
        _s = "TDDinC#fromAtoZ";
    }
    /*
    <summary>
    Assert that CanonicalFormHelper.Capitalize_EFA returns the expected result.
    It must be the capitalized string or empty if null or empty.
    </summary>
    */
    [Test]
    public void CanonicalForm_EFA_isCapitalized()
    {
        /// Act Assert
        Assert.That(CanonicalFormHelper.Capitalize_EFA(_s), Is.EqualTo("TDDINC#FROMATOZ"));
    }
    /*
    <summary>
    Assert that CanonicalFormHelper.Capitalize_EFO returns the expected result.
    It throws ArgumentNullException if the argument is null.
    </summary>
    */
    [Test]
    public void CanonicalForm_EFO_isCapitalized()
    {
        /// Act Assert
        Assert.That(CanonicalFormHelper.Capitalize_EFO(_s), Is.EqualTo("TDDINC#FROMATOZ"));
    }
    /*
    <summary>
    Assert that CanonicalFormHelper.Capitalize_EFO_Linq returns the expected result.
    It throws ArgumentNullException if the argument is null.
    </summary>
    */
    /*[Test]
    public void CanonicalForm_EFO_Linq_isCapitalized()
    {
        /// Act Assert
        Assert.That(CanonicalFormHelper.Capitalize_EFO_Linq(_s), Is.EqualTo("TDDINC#FROMATOZ"));
    }*/
    /*
    <summary>
    Assert that CanonicalFormHelper.Capitalize_EFA returns the expected result.
    It throws ArgumentNullException if the argument is null.
    </summary>
    */
    [Test]
    public void CanonicalForm_EFA_nullArgumentHandled()
    {
        /// Arrange
        _canonicalizeDelegate delegateCapitalize = new _canonicalizeDelegate(CanonicalFormHelper.Capitalize_EFA);
        /// Act Assert
        Assert.That(delegateCapitalize(_s_null), Is.EqualTo(""));
    }
    /*
    <summary>
    Assert that CanonicalFormHelper.Capitalize_EFA returns the expected result.
    It throws ArgumentException if the argument is an empty string.
    </summary>
    */
    [Test]
    public void CanonicalForm_EFA_emptyStringArgumentHandled()
    {
        /// Act Assert
        Assert.That(CanonicalFormHelper.Capitalize_EFA(""), Is.EqualTo(""));
    }
    /*
    <summary>
    Assert that CanonicalFormHelper.Capitalize_EFO returns the expected result.
    It throws ArgumentNullException if the argument is null.
    </summary>
    */
    /*public void CanonicalForm_EFO_nullArgumentHandled()
    {
        /// Arrange
        _canonicalizeDelegate delegateCapitalize = new _canonicalizeDelegate(CanonicalFormHelper.Capitalize_EFO);
        /// Act Assert
        Assert.That(delegateCapitalize(_s_null), Throws.ArgumentNullException);
    }*/
    /*
    <summary>
    Assert that CanonicalFormHelper.Capitalize_EFO returns the expected result.
    It throws ArgumentException if the argument is an empty string.
    </summary>
    */
    /*public void CanonicalForm_EFO_emptyStringArgumentHandled()
    {
        /// Arrange
        _canonicalizeDelegate delegateCapitalize = new _canonicalizeDelegate(CanonicalFormHelper.Capitalize_EFO);
        /// Act Assert
        Assert.That(delegateCapitalize(_s_null), Throws.ArgumentException);
    }*/
    /*
    <summary>
    Assert that CanonicalFormHelper.Capitalize_EFO_Linq returns the expected result.
    It throws ArgumentNullException if the argument is null.
    </summary>
    */
    /*public void CanonicalForm_EFO_Linq_nullArgumentHandled()
    {
        /// Arrange
        _canonicalizeDelegate delegateCapitalize = new _canonicalizeDelegate(CanonicalFormHelper.Capitalize_EFO_Linq);
        /// Act Assert
        Assert.That(delegateCapitalize(_s_null), Throws.ArgumentNullException);
    }*/
    /*
    <summary>
    Assert that CanonicalFormHelper.Capitalize_EFO_Linq returns the expected result.
    It throws ArgumentException if the argument is an empty string.
    </summary>
    */
    /*public void CanonicalForm_EFO_Linq_emptyStringArgumentHandled()
    {
        /// Arrange
        _canonicalizeDelegate delegateCapitalize = new _canonicalizeDelegate(CanonicalFormHelper.Capitalize_EFO_Linq);
        /// Act Assert
        Assert.That(delegateCapitalize(""), Throws.ArgumentException);
    }*/
}