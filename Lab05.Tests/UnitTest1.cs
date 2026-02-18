namespace Lab05.Tests;

public class Tests
{
    // [SetUp]
    // public void Setup(){}
    // Assert.Pass();

    [Test]  // Sets an attribute that our test can be run by dotnet test
    public void RNTwoPositiveTest()     // Tests that (12/6) will return (2/1), Unit Test #1
    {
        var test = new RationalNumber(12, 6);
        
        Assert.Multiple(() =>
        {
            Assert.That(test.Numerator, Is.EqualTo(2));
            Assert.That(test.Denominator, Is.EqualTo(1));
        });
    }
    [Test]
    public void RNPositiveNegativeTest()     // Tests that (12/-6) will return (2/-1), Unit Test #2
    {
        var test = new RationalNumber(12, -6);
        
        Assert.Multiple(() =>
        {
            Assert.That(test.Numerator, Is.EqualTo(2));
            Assert.That(test.Denominator, Is.EqualTo(-1));
        });
    }
    [Test]
    public void RNNegativePositiveTest()     // Tests that (-12/6) will return (-2/1), Unit Test #3
    {
        var test = new RationalNumber(-12, 6);
        
        Assert.Multiple(() =>
        {
            Assert.That(test.Numerator, Is.EqualTo(-2));
            Assert.That(test.Denominator, Is.EqualTo(1));
        });
    }
    [Test]
    public void RNTwoNegativeTest()     // Tests that (-12/-6) will return (2/1), Unit Test #4
    {
        var test = new RationalNumber(-12, -6);
        
        Assert.Multiple(() =>
        {
            Assert.That(test.Numerator, Is.EqualTo(2));
            Assert.That(test.Denominator, Is.EqualTo(1));
        });
    }
    [Test]
    public void RNSimplifyTest()     // Tests that (60/3600) can be simplified to (1/60), Unit Test #5
    {
        var test = new RationalNumber(60, 3600);
        
        Assert.Multiple(() =>
        {
            Assert.That(test.Numerator, Is.EqualTo(1));
            Assert.That(test.Denominator, Is.EqualTo(60));
        });
    }
    [Test]
    public void RNNoSimplifyTest()     // Tests that (6/25) won't be simplified, Unit Test #6
    {
        var test = new RationalNumber(6, 25);
        
        Assert.Multiple(() =>
        {
            Assert.That(test.Numerator, Is.EqualTo(6));
            Assert.That(test.Denominator, Is.EqualTo(25));
        });
    }
    [Test]
    public void RNEqualTest()     // Tests RN Equals and GHC overrides, Unit Test #7
    {
        var test = new RationalNumber(20, 10);
        var testcompare = new RationalNumber(4, 2);
        
        Assert.Multiple(() =>
        {
            Assert.That(test.Equals(testcompare), Is.True);
            Assert.That(test.GetHashCode().Equals(testcompare.GetHashCode()), Is.True);
        });
    }
    [Test]
    public void MNSimplifyTest()     // Tests that (25/6) is simplified to (4 1/6), Unit Test #8
    {
        var test = new MixedNumber(25, 6);
        
        Assert.Multiple(() =>
        {
            Assert.That(test.WholeUnits, Is.EqualTo(4));
            Assert.That(test.PartialUnits.Numerator, Is.EqualTo(1));
            Assert.That(test.PartialUnits.Denominator, Is.EqualTo(6));
        });
    }
    [Test]
    public void MNNoWholeTest()     // Tests that (9/30) is simplified to (0 3/10), Unit Test #9
    {
        var test = new MixedNumber(9, 30);
        
        Assert.Multiple(() =>
        {
            Assert.That(test.WholeUnits, Is.EqualTo(0));
            Assert.That(test.PartialUnits.Numerator, Is.EqualTo(3));
            Assert.That(test.PartialUnits.Denominator, Is.EqualTo(10));
        });
    }
    [Test]
    public void MNEqualTest()     // Tests MN Equals and GHC overrides, Unit Test #10
    {
        var test = new MixedNumber(125, 50);
        var testcompare = new MixedNumber(5, 2);
        
        Assert.Multiple(() =>
        {
            Assert.That(test.Equals(testcompare), Is.True);
            Assert.That(test.GetHashCode().Equals(testcompare.GetHashCode()), Is.True);
        });
    }
    [Test]
    public void RNZeroDivideTest()     // Makes sure that the RN constructor throws if the denominator is 0
    {
        Assert.Throws<DivideByZeroException>(() => new RationalNumber(1, 0));
    }
    [Test]
    public void MNNegativeHandlingTest()     // Testing my remainder solution
    {
        var test = new MixedNumber(-25, 5);
        var testTwo = new MixedNumber(25, -5);
        
        Assert.Multiple(() =>
        {
            Assert.That(test.WholeUnits.Equals(-5), Is.True);
            Assert.That(testTwo.WholeUnits.Equals(-5), Is.True);
        });
    }
}