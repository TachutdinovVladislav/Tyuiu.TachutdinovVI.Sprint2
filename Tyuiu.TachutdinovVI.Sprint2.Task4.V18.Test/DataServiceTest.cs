using Tyuiu.TachutdinovVI.Sprint2.Task4.V18.Lib;

namespace Tyuiu.TachutdinovVI.Sprint2.Task4.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 10;

            double res = ds.Calculate(x, y);
            double wait = 36.012;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 4;

            double res = ds.Calculate(x, y);
            double wait = 41.500;

            Assert.AreEqual(wait, res);
        }
    }
}