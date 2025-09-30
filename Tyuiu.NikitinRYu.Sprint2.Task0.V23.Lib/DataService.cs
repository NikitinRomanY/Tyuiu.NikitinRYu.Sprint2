using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NikitinRYu.Sprint2.Task0.V23.Lib
{
    public class DataService : ISprint2Task0V23
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];

            result[0] = x < y;
            result[1] = (x + 100) > y;
            result[2] = (y - 690) == x;
            result[3] = x != y;
            result[4] = y <= 700;
            result[5] = (2 * x) > (y / 4);

            return result;
        }
    }
}
