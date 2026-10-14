using Tyuiu.TachutdinovVI.Sprint2.Task3.V27.Lib;

namespace Tyuiu.TachutdinovVI.Sprint2.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            double x = 0, res = ds.Calculate(x);

            Assert.AreEqual(0.25, res);
        }
    }
}