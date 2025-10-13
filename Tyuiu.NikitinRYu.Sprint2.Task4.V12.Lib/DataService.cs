using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NikitinRYu.Sprint2.Task4.V12.Lib
{
    public class DataService : ISprint2Task4V12
    {
        public double Calculate(double x, double y)
        {
            double z = Math.Sqrt(x) > 2 * y
                ? Math.Pow(7 + 2 / (y * y), x)
                : (3 * x * x - Math.Cos(y * y) + 10)
                  / (y * y - Math.Pow(Math.Sin(x), 2) + 12);

            return Math.Round(z, 3);
        }
    }
}
