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
}
