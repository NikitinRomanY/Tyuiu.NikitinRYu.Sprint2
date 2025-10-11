using Tyuiu.NikitinRYu.Sprint2.Task3.V20.Lib;

namespace Tyuiu.NikitinRYu.Sprint2.Task3.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateXZero()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 0.75;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
