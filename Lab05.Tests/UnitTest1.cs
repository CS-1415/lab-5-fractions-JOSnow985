namespace Lab05.Tests;

public class Tests
{
    // [SetUp]
    // public void Setup(){}
    // Assert.Pass();

    [Test]  // Sets an attribute that our test is called when we run dotnet test
    public void RNTwoPositiveTest()     // Tests that 12 and 6 produce the expected behavior
    {
        var test = new RationalNumber(12, 6);
        
        Assert.Multiple(() =>
        {
            Assert.That(test.Numerator, Is.EqualTo(2));
            Assert.That(test.Denominator, Is.EqualTo(1));
        });
    }
    [Test]
    public void RNOverrideTest()     // Tests that our overriden methods are working properly
    {
        var test = new RationalNumber(12, 6);
        var testcompare = new RationalNumber(24, 12);
        
        Assert.Multiple(() =>
        {
            Assert.That(test.Equals(testcompare), Is.True);
            Assert.That(test.GetHashCode().Equals(testcompare.GetHashCode()), Is.True);
        });
    }
}