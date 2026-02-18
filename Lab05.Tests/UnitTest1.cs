namespace Lab05.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ClassTest()     // Tests our class has the properties and types
    {
        var test = new RationalNumber(12, 6);
        
        Assert.Multiple(() =>
        {
            Assert.That(test, Has.Property("Numerator").With.TypeOf<int>());
            Assert.That(test, Has.Property("Denominator").With.TypeOf<int>());
        });
    } 
}