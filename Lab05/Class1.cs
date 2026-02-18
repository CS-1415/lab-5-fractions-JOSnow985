namespace Lab05;

public class RationalNumber
{
    // Fields
    private readonly int _numerator;
    private readonly int _denominator;

    // Constructors
    public RationalNumber(int numerator, int denominator)
    {
        // We want a positive rational number if we're dividing a negative by a negative
        if (numerator < 0 && denominator < 0)
        {
            numerator = Math.Abs(numerator);
            denominator = Math.Abs(denominator);
        }

        // Divide both numerator and denominator by the gcd and set our fields
        int gcd = GreatestCommonDenominator(numerator, denominator);
        _numerator = numerator / gcd;
        _denominator = denominator / gcd;
    }

    // Properties
    public int Numerator => _numerator;
    public int Denominator => _denominator;

    // Methods
    // Overriding Equals(object? obj) 
    public override bool Equals(object? obj)
    {   
        RationalNumber? rn = obj as RationalNumber; // rn will be null if obj isn't a RationalNumber, null or not
        // Check if rn is null first, then if the properties match. 
        if (rn == null) 
            return false;
        else if (rn.Numerator != Numerator || rn.Denominator != Denominator) 
            return false;
        else
            return true;
    }
    // Overriding GetHashCode(), uses both Numerator and Denominator
    public override int GetHashCode() => HashCode.Combine(Numerator, Denominator);

    // Recursive Method to eventually return the greatest common denominator
    private static int GreatestCommonDenominator(int a, int b) => b == 0 ? Math.Abs(a) : GreatestCommonDenominator(b, a % b);
}

public class MixedNumber
{
    // Fields
    private readonly int _wholeunits;
    private readonly RationalNumber _partialunits;

    // Constructors
    public MixedNumber(RationalNumber rn)
    {
        // Math.DivRem() gives us the quotient and the remainder at the same time
        _wholeunits = Math.DivRem(rn.Numerator, rn.Denominator, out int remainder);
        // Doesn't handle the weird negative behavior yet
        _partialunits = new RationalNumber(remainder,rn.Denominator);
    }
    public MixedNumber(int n, int d) : this(new RationalNumber(n, d)) {}
    // Properties
    public int WholeUnits => _wholeunits;

    public RationalNumber PartialUnits => _partialunits;

    //Methods
    // Overriding Equals(object? obj) 
    public override bool Equals(object? obj)
    {   
        MixedNumber? mn = obj as MixedNumber;
        if (mn == null) 
            return false;
        else if (WholeUnits != mn.WholeUnits || !PartialUnits.Equals(mn.PartialUnits))
            return false;
        else
            return true;
    }
    // Overriding GetHashCode(), uses both Numerator and Denominator
    public override int GetHashCode() => HashCode.Combine(WholeUnits, PartialUnits);
}