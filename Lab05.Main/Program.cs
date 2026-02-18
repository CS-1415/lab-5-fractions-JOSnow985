// Jaden Olvera, CS1410, Lab 5 - Fractions
using Lab05;

Console.Clear();

while (true)
{
    Console.WriteLine("Want a fraction simplified? Give us a numerator and a denominator!");
    bool assigned = false;
    int numerator = 1;
    while (!assigned)
    {
        Console.Write("Your numerator: ");
        if (int.TryParse(Console.ReadLine(), out numerator))
            assigned = true;
        else
            Console.WriteLine("Sorry, it has to be an integer we can parse!");
    }

    assigned = false;
    int denominator = 1;
    while (!assigned)
    {
        Console.Write("Your denominator: ");
        if (int.TryParse(Console.ReadLine(), out denominator))
            if (denominator == 0)
                Console.WriteLine("Sorry, we can't divide by zero.");
            else
                assigned = true;
        else
            Console.WriteLine("Sorry, it has to be an integer we can parse!");
    }

    RationalNumber rn = new(numerator, denominator);
    Console.WriteLine($"\nYour rational number is: {rn.Numerator}{(rn.Denominator == 1 ? "" : $"/{rn.Denominator}")}, cool!");
    if (rn.Denominator != 1)
    {
        MixedNumber mn = new(rn);
        if (mn.WholeUnits != 0)
            Console.WriteLine($"If you wrote that as a mixed number it would be {mn.WholeUnits} {mn.PartialUnits.Numerator}/{mn.PartialUnits.Denominator}, also cool!");
    }
    Console.WriteLine("\nPress any key to try another!");
    Console.ReadKey();
    Console.Clear();
}