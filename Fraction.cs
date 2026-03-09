namespace MathOpWithFractions_20250305;

internal class Fraction
{
    private int _m;
    private int _n;
    public int M
    {
        get { return _m; } 
        set { _m = value; }
    }
    public int N
    {
        get { return _n; }
        set
        {
            if (value == 0)
                throw new ArgumentException("Denominator cannot be zero");
            else
                _n = value;
        }
    }

    public Fraction()
    {
        return;
    }

    public Fraction(int _m, int _n)
    {
        M = _m;
        N = _n;
    }

    public static Fraction Add(Fraction f1, Fraction f2)
    {
        int numerator = f1.M * f2.N + f2.M * f1.N;
        int denominator = f1.N * f2.N;

        //Simplify(numerator, denominator);
        int minValue = Math.Abs(numerator) < Math.Abs(denominator) ? Math.Abs(numerator) : Math.Abs(denominator);
        //Console.WriteLine(minValue);

        if (numerator % minValue != 0 || denominator % minValue != 0)
        {
            for (int i = minValue / 2; i > 1; i--)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    numerator /= i;
                    denominator /= i;
                    break;
                }
            }
        }
        else if (numerator % minValue == 0 && denominator % minValue == 0)
        {
            numerator /= minValue;
            denominator /= minValue;
        }

        var f3 = new Fraction()
        {
            _m = numerator,
            _n = denominator
        };

        return f3;
    }

    public static Fraction operator +(Fraction f1, Fraction f2) => Fraction.Add(f1, f2);

    //public void Sub(Fraction f1, Fraction f2, out int numerator, out int denominator)
    //{
    //    numerator = f1.M * f2.N - f2.M * f1.N;
    //    denominator = f1.N * f2.N;
    //    //Simplify(numerator, denominator);
    //    int minValue = Math.Abs(numerator) < Math.Abs(denominator) ? Math.Abs(numerator) : Math.Abs(denominator);
    //    Console.WriteLine(minValue);

    //    if (numerator % minValue != 0 || denominator % minValue != 0)
    //    {
    //        for (int i = minValue / 2; i > 1; i--)
    //        {
    //            if (numerator % i == 0 && denominator % i == 0)
    //            {
    //                numerator /= i;
    //                denominator /= i;
    //                break;
    //            }
    //        }
    //    }
    //    else if (numerator % minValue == 0 && denominator % minValue == 0)
    //    {
    //        numerator /= minValue;
    //        denominator /= minValue;
    //    }
    //}

    //public void Mul(Fraction f1, Fraction f2, out int numerator, out int denominator)
    //{
    //    numerator = f1.M * f2.M;
    //    denominator = f1.N * f2.N;

    //    //Simplify(numerator, denominator);
    //    int minValue = Math.Abs(numerator) < Math.Abs(denominator) ? Math.Abs(numerator) : Math.Abs(denominator);
    //    Console.WriteLine(minValue);

    //    if (numerator % minValue != 0 || denominator % minValue != 0)
    //    {
    //        for (int i = minValue / 2; i > 1; i--)
    //        {
    //            if (numerator % i == 0 && denominator % i == 0)
    //            {
    //                numerator /= i;
    //                denominator /= i;
    //                break;
    //            }
    //        }
    //    }
    //    else if (numerator % minValue == 0 && denominator % minValue == 0)
    //    {
    //        numerator /= minValue;
    //        denominator /= minValue;
    //    }
    //}

    //public void Div(Fraction f1, Fraction f2, out int numerator, out int denominator)
    //{
    //    numerator = f1.M * f2.N;
    //    denominator = f1.N * f2.M;
    //    //Simplify(numerator, denominator);
    //    int minValue = Math.Abs(numerator) < Math.Abs(denominator) ? Math.Abs(numerator) : Math.Abs(denominator);
    //    Console.WriteLine(minValue);

    //    if (numerator % minValue != 0 || denominator % minValue != 0)
    //    {
    //        for (int i = minValue / 2; i > 1; i--)
    //        {
    //            if (numerator % i == 0 && denominator % i == 0)
    //            {
    //                numerator /= i;
    //                denominator /= i;
    //                break;
    //            }
    //        }
    //    }
    //    else if (numerator % minValue == 0 && denominator % minValue == 0)
    //    {
    //        numerator /= minValue;
    //        denominator /= minValue;
    //    }
    //}

    //public void Simplify(int a, int b)
    //{
    //    int minValue = Math.Abs(a) < Math.Abs(b) ? Math.Abs(a) : Math.Abs(b);
    //    if (a % minValue != 0 || b % minValue != 0)
    //    {
    //        for (int i = minValue / 2; i > 1; i--)
    //        {
    //            if (a % i == 0 && b % i == 0)
    //            {
    //                a /= i;
    //                b /= i;
    //                break;
    //            }
    //        }
    //    }
    //    else if (a % minValue == 0 && b % minValue == 0)
    //    {
    //        a /= minValue;
    //        b /= minValue;
    //    }

    //    M = a;
    //    N = b;
    //}
}
