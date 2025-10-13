using Tyuiu.BocharovaES.Sprint2.Task5.V9.Lib;
namespace Tyuiu.BocharovaES.Sprint2.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int n = 25;
            int m = 11;
            string wait = "11.26";
            Assert.AreEqual(wait, ds.FindDateOfNextDay(m, n));
        }
    }
}
