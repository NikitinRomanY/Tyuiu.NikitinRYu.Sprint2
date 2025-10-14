using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NikitinRYu.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x * x + y * y > 1)
                return false;

            if (x >= 0 && y <= 0)
                return false;

            if (x >= 0 && y >= 0 && y <= x)
                return false;

            return true;
        }
    }
}
