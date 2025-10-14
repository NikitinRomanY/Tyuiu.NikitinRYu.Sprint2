using Tyuiu.NikitinRYu.Sprint2.Task7.V11.Lib;

namespace Tyuiu.NikitinRYu.Sprint2.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0.5));

            Assert.IsFalse(ds.CheckDotInShadedArea(0.5, -0.5));

            Assert.IsFalse(ds.CheckDotInShadedArea(0.5, 0.3));

            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));
        }
    }
}
