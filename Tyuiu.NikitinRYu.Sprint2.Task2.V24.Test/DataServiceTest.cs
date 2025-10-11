using Tyuiu.NikitinRYu.Sprint2.Task2.V24.Lib;

namespace Tyuiu.NikitinRYu.Sprint2.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 9;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
