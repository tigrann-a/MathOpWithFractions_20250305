using MathOpWithFractions_20250305;

Fraction fraction1 = new Fraction();
fraction1.M = 3;
fraction1.N = 4;

Fraction fraction2 = new Fraction();
fraction2.M = 4;
fraction2.N = 3;

void Add(Fraction f1, Fraction f2, out int numerator, out int denominator)
{
    denominator = f1.N * f2.N;
    numerator = denominator / f1.N * f1.M + denominator / f2.N * f2.M;
}

void Sub(Fraction f1, Fraction f2, out int numerator, out int denominator)
{
    denominator = f1.N * f2.N;
    numerator = denominator / f1.N * f1.M - denominator / f2.N * f2.M;
}

void Mul(Fraction f1, Fraction f2, out int numerator, out int denominator)
{
    numerator = f1.M * f2.M;
    denominator = f1.N * f2.N;
}

void Div(Fraction f1, Fraction f2, out int numerator, out int denominator)
{
    numerator = f1.M * f2.N;
    denominator = f1.N * f2.M;
}

Add(fraction1, fraction2, out int n1, out int d1);
Console.WriteLine($"Addition: {n1}/{d1}");

Sub(fraction1, fraction2, out int n2, out int d2);
Console.WriteLine($"Subtraction: {n2}/{d2}");

Mul(fraction1, fraction2, out int n3, out int d3);
Console.WriteLine($"Multiplication: {n3}/{d3}");

Div(fraction1, fraction2, out int n4, out int d4);
Console.WriteLine($"Division: {n4}/{d4}");
