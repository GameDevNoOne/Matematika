namespace Matematika
{
    /// <summary>Matematične funkcije</summary>
    public static class Funkcije
    {
        public static double Abs(double x)
    {
        if(x > 0)
        {
            return x;
        }
        else
        {
            return x*-1;
        }
    }
    }
}
