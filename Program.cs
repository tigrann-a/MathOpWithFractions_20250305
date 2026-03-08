using MathOpWithFractions_20250305;
using System.Threading.Channels;

Console.WriteLine("Please enter the numerator for the first fraction: ");
string? numeratorTxt1 = Console.ReadLine();
bool isNum1 = int.TryParse(numeratorTxt1, out int numerator1);

Console.WriteLine("Please enter the denominator for the first fraction: ");
string? denominatorTxt1 = Console.ReadLine();
bool isNum2 = int.TryParse(denominatorTxt1, out int denominator1);

Fraction fraction1 = new Fraction(numerator1, denominator1);
Console.WriteLine($"{numerator1} / {denominator1}");

Console.WriteLine("Please enter the numerator for the second fraction: ");
string? numeratorTxt2 = Console.ReadLine();
bool isNum3 = int.TryParse(numeratorTxt2, out int numerator2);

Console.WriteLine("Please enter the denominator for the second fraction: ");
string? denominatorTxt2 = Console.ReadLine();
bool isNum4 = int.TryParse(denominatorTxt2, out int denominator2);

Fraction fraction2 = new Fraction(numerator2, denominator2);
Console.WriteLine($"{numerator2} / {denominator2}");

fraction1.Add(fraction2, out int n1, out int d1);
Console.WriteLine($"Addition: {n1}/{d1}");

fraction1.Sub(fraction2, out int n2, out int d2);
Console.WriteLine($"Subtraction: {n2}/{d2}");

fraction1.Mul(fraction2, out int n3, out int d3);
Console.WriteLine($"Multiplication: {n3}/{d3}");

fraction1.Div(fraction2, out int n4, out int d4);
Console.WriteLine($"Division: {n4}/{d4}");
