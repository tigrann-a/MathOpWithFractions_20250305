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

        Simplify(numerator, denominator, out int simNum, out int simDen);

        var f3 = new Fraction()
        {
            _m = simNum,
            _n = simDen
        };

        return f3;
    }

    public static Fraction operator +(Fraction f1, Fraction f2) => Fraction.Add(f1, f2);

    public static Fraction Sub(Fraction f1, Fraction f2)
    {
        int numerator = f1.M * f2.N - f2.M * f1.N;
        int denominator = f1.N * f2.N;

        Simplify(numerator, denominator, out int simNum, out int simDen);

        var f3 = new Fraction()
        {
            _m = simNum,
            _n = simDen
        };

        return f3;
    }

    public static Fraction operator -(Fraction f1, Fraction f2) => Fraction.Sub(f1, f2);

    public static Fraction Mul(Fraction f1, Fraction f2)
    {
        int numerator = f1.M * f2.M;
        int denominator = f1.N * f2.N;

        Simplify(numerator, denominator, out int simNum, out int simDen);

        var f3 = new Fraction()
        {
            _m = simNum,
            _n = simDen
        };

        return f3;
    }

    public static Fraction operator *(Fraction f1, Fraction f2) => Fraction.Mul(f1, f2);

    public static Fraction Div(Fraction f1, Fraction f2)
    {
        int numerator = f1.M * f2.N;
        int denominator = f1.N * f2.M;
        Simplify(numerator, denominator, out int simNum, out int simDen);

        var f3 = new Fraction()
        {
            _m = simNum,
            _n = simDen
        };

        return f3;
    }

    public static Fraction operator /(Fraction f1, Fraction f2) => Fraction.Div(f1, f2);

    public static void Simplify(int num, int den, out int simNum, out int simDen)
    {

        int minValue = Math.Abs(num) < Math.Abs(den) ? Math.Abs(num) : Math.Abs(den);
        if (num % minValue != 0 || den % minValue != 0)
        {
            for (int i = minValue / 2; i > 1; i--)
            {
                if (num % i == 0 && den % i == 0)
                {
                    num /= i;
                    den /= i;
                    break;
                }
            }
        }
        else if (num % minValue == 0 && den % minValue == 0)
        {
            num /= minValue;
            den /= minValue;
        }

        simNum = num;
        simDen = den;
    }
}
