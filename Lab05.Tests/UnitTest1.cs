namespace Lab05.Tests;

public class Tests
{
    // [SetUp]
    // public void Setup(){}
    // Assert.Pass();

    [Test]  // Sets an attribute that our test is called when we run dotnet test
    public void TwoPositiveTest()     // Tests that 12 and 6 produce the expected behavior
    {
        var test = new RationalNumber(12, 6);
        
        Assert.Multiple(() =>
        {
            Assert.That(test.Numerator, Is.EqualTo(2));
            Assert.That(test.Denominator, Is.EqualTo(1));
        });
    }
}