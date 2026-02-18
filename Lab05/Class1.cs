namespace Lab05;

public class RationalNumber
{
    // Fields
    private readonly int _numerator;
    private readonly int _denominator;

    // Constructors
    public RationalNumber(int numerator, int denominator)
    {
        // Find GCD
        int gcd = GreatestCommonDenominator(numerator, denominator);
        // Divide both numerator and denominator by gcd and set our fields
        _numerator = numerator / gcd;
        _denominator = denominator / gcd;
    }

    // Properties
    public int Numerator => _numerator;
    public int Denominator => _denominator;

    // Methods
    // Recursive Method to eventually return the greatest common denominator
    private static int GreatestCommonDenominator(int a, int b) => b == 0 ? Math.Abs(a) : GreatestCommonDenominator(b, a % b);
}
