using Tyuiu.BocharovaES.Sprint2.Task4.V26.Lib;
namespace Tyuiu.BocharovaES.Sprint2.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 12;
            Assert.AreEqual(res, wait);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 16;
            Assert.AreEqual(res, wait);
        }
    }
}
