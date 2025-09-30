using Tyuiu.NikitinRYu.Sprint2.Task0.V23.Lib;

namespace Tyuiu.NikitinRYu.Sprint2.Task0.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidTest()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 795;
            bool[] wait = { true, false, true, true, false, true };
            bool[] res = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
