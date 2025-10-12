using Tyuiu.BocharovaES.Sprint2.Task3.V13.Lib;
namespace Tyuiu.BocharovaES.Sprint2.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = -7;
            Assert.AreEqual(res, wait);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(res, wait);
        }
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 11;
            Assert.AreEqual(res, wait);
        }
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -18;
            double res = ds.Calculate(x);
            double wait = 198.056;
            Assert.AreEqual(res, wait);
        }
    }
}
