using Tyuiu.BocharovaES.Sprint2.Task6.V6.Lib;
namespace Tyuiu.BocharovaES.Sprint2.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();
            int m =6;
            int k =1;
            var res = ds.FindCardNameAndValue(k,m);
            string wait = "Шестёрка пик";
            Assert.AreEqual(wait, res);
        }
    }
}
