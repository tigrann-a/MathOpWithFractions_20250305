using MathOpWithFractions_20250305;

Console.WriteLine("Please enter the numerator for the first fraction: ");
string? numeratorTxt1 = Console.ReadLine();
bool isNum1 = int.TryParse(numeratorTxt1, out int numerator1);

Console.WriteLine("Please enter the denominator for the first fraction: ");
string? denominatorTxt1 = Console.ReadLine();
bool isNum2 = int.TryParse(denominatorTxt1, out int denominator1);

Fraction fraction1 = new Fraction(numerator1, denominator1);
//Console.WriteLine($"{numerator1} / {denominator1}");

Console.WriteLine("Please enter the numerator for the second fraction: ");
string? numeratorTxt2 = Console.ReadLine();
bool isNum3 = int.TryParse(numeratorTxt2, out int numerator2);

Console.WriteLine("Please enter the denominator for the second fraction: ");
string? denominatorTxt2 = Console.ReadLine();
bool isNum4 = int.TryParse(denominatorTxt2, out int denominator2);

Fraction fraction2 = new Fraction(numerator2, denominator2);
//Console.WriteLine($"{numerator2} / {denominator2}");

//Fraction fractionAdd = Fraction.Add(fraction1, fraction2);
//Fraction fractionSub = Fraction.Sub(fraction1, fraction2);
//Fraction fractionMul = Fraction.Mul(fraction1, fraction2);
//Fraction fractionDiv = Fraction.Div(fraction1, fraction2);

Fraction fractionAdd = fraction1 + fraction2;
Fraction fractionSub = fraction1 - fraction2;
Fraction fractionMul = fraction1 * fraction2;
Fraction fractionDiv = fraction1 / fraction2;

Console.WriteLine($"{fractionAdd.M} / {fractionAdd.N}");
Console.WriteLine($"{fractionSub.M} / {fractionSub.N}");
Console.WriteLine($"{fractionMul.M} / {fractionMul.N}");
Console.WriteLine($"{fractionDiv.M} / {fractionDiv.N}");
