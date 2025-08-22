# Lab-5-Fractions
Lab 5 - Simplified Fractions and Rational Numbers
General Learning Objectives

Use a modern operating system and utilities.

Use an integrated development environment to develop a program.

Solve problems and develop programs using the control structures of sequence, selection, and repetition, following a disciplined approach.

Objectives
Practice overriding GetHashCode() and Equals()
Practice working with read-only properties
Practice working with overloaded constructors
Practice constructor delegation (chaining constructors)
More practice with unit testing
More practice with using composition in OO Design
Take what we've been discussing in class and bring it all together.
Basic Environment Setup
Accept the GitHub Classroom Assignment.
Open a terminal.
Navigate to your code directory for the course (e.g.: cd my-cs1415-dir).
Run git clone {yourUrl} to make a local copy of your repository.
Run code {nameOfYourRepo} to open that directory in VS Code.
Open the integrated terminal in VS Code (Ctrl+`, or the Terminal menu -> New Terminal).
Creating the Library and Test Projects
Navigate to your repository folder in the VS Code terminal.
Create the following three projects:
dotnet new classlib -o Lab05
dotnet new nunit -o Lab05.Tests
dotnet new console -o Lab05.Main
Add references to the tests and main driver from the libary:
dotnet add Lab05.Tests reference Lab05
dotnet add Lab05.Main reference Lab05
Create a solution pointing to all three projects:
dotnet new sln
dotnet sln add Lab05 Lab05.Tests Lab05.Main
The sample test should run and pass:
dotnet test
Programming

Follow Test Driven Development (TDD) practices to implement the following functionality:

Write a RationalNumber class that takes an int numerator and int denominator in its constructor, and has two read-only properties: int Numerator, int Denominator
In the RationalNumber constructor, simplify the fraction (e.g. 12/6 becomes 2/1), such that if I called new RationalNumber(12,6) then the Numerator property would be 2 and the Denominator property would be 1. Below is a method you might find useful in simplifying fractions.

static int GreatestCommonDenominator(int a, int b)

{

if (b == 0)

{ return Math.Abs(a); }

else { return GreatestCommonDenominator(b, a % b); }

}

Override the GetHashCode and Equals methods for RationalNumber. Below is an example of how you can use the HashCode.Combine() method to return a hash code for your object. Ensure every field used in your Equals() implementation is also included in your GetHashCode() implementation. csharp public override int GetHashCode() { return HashCode.Combine(field1, field2, field3); }
Write a MixedNumber class that has two constructors
one that takes an int numerator, and int denominator
another one that takes a RationalNumber instance
Chain the constructors so that MixedNumber(int, int) calls MixedNumber(RationalNumber)
In the constructor of MixedNumber, set the correct number of whole units to a read-only property named WholeUnits of type int, set the remaining fraction to a read-only property named PartialUnits of type RationalNumber.
Override the GetHashCode and Equals methods for MixedNumber
Write Unit Tests
Show creating a rational number with a positive numerator and positive denominator
Create a rational number with a positive numerator and negative denominator
Create a rational number with a negative numerator and positive denominator
Create a rational number with a negative numerator and negative denominator
Create a rational number that can be simplified and ensure it is properly simplified
Create a rational number that cannot be simplified and ensure it is not changed
Ensure that new RationalNumber(20,10).Equals(new RationalNumber(4,2)) is true
Create a MixedNumber object with a number that can be simplified into a whole and partial value
Create a MixedNumber object with a number that will not have a whole value
Ensure that new MixedNumber(125,50).Equals(new MixedNumber(5,2)) is true
Code the Main() method of Lab05.Main to prompt the user to enter a numerator and a denominator, create a RationalNumber and output the reduced numerator and denominator back to the user.
