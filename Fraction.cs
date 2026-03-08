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

    public Fraction(int _m, int _n)
    {
        this._m = _m;
        this._n = _n;
    }

    public void Add(Fraction f2, out int numerator, out int denominator)
    {
        denominator = _n * f2.N;
        numerator = denominator / _n * _m + denominator / f2.N * f2.M;

        int minValue = Math.Abs(numerator) < Math.Abs(denominator) ? Math.Abs(numerator) : Math.Abs(denominator);
        Console.WriteLine(minValue);

        if (numerator % denominator != 0)
        {
            for(int i = minValue - 1; i > 1; i--)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    numerator /= i;
                    denominator /= i;
                    break;
                }
            }
        }
        else
        {
            numerator /= denominator;
            denominator /= denominator;
        }

    }

    public void Sub(Fraction f2, out int numerator, out int denominator)
    {
        denominator = _n * f2.N;
        numerator = denominator / _n * _m - denominator / f2.N * f2.M;

        int minValue = Math.Abs(numerator) < Math.Abs(denominator) ? Math.Abs(numerator) : Math.Abs(denominator);
        Console.WriteLine(minValue);

        if (numerator % denominator != 0)
        {
            for (int i = minValue - 1; i > 1; i--)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    numerator /= i;
                    denominator /= i;
                    break;
                }
            }
        }
        else
        {
            numerator /= denominator;
            denominator /= denominator;
        }
    }

    public void Mul(Fraction f2, out int numerator, out int denominator)
    {
        numerator = _m * f2.M;
        denominator = _n * f2.N;

        int minValue = Math.Abs(numerator) < Math.Abs(denominator) ? Math.Abs(numerator) : Math.Abs(denominator);
        Console.WriteLine(minValue);

        if (numerator % denominator != 0)
        {
            for (int i = minValue - 1; i > 1; i--)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    numerator /= i;
                    denominator /= i;
                    break;
                }
            }
        }
        else
        {
            numerator /= denominator;
            denominator /= denominator;
        }
    }

    public void Div(Fraction f2, out int numerator, out int denominator)
    {
        numerator = _m * f2.N;
        denominator = _n * f2.M;

        int minValue = Math.Abs(numerator) < Math.Abs(denominator) ? Math.Abs(numerator) : Math.Abs(denominator);
        Console.WriteLine(minValue);

        if (numerator % denominator != 0)
        {
            for (int i = minValue - 1; i > 1; i--)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    numerator /= i;
                    denominator /= i;
                    break;
                }
            }
        }
        else
        {
            numerator /= denominator;
            denominator /= denominator;
        }
    }
}
