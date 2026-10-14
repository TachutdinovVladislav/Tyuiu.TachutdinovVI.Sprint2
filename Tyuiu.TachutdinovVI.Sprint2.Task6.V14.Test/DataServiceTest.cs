
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TachutdinovVI.Sprint2.Task6.V14.Lib;

namespace Tyuiu.TachutdinovVI.Sprint2.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDayNames()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(1, 1));
            Assert.AreEqual("Вторник", ds.FindDayName(1, 2));
            Assert.AreEqual("Среда", ds.FindDayName(1, 3));
            Assert.AreEqual("Четверг", ds.FindDayName(1, 4));
            Assert.AreEqual("Пятница", ds.FindDayName(1, 5));
            Assert.AreEqual("Суббота", ds.FindDayName(1, 6));
            Assert.AreEqual("Воскресенье", ds.FindDayName(1, 7));
        }

        [TestMethod]
        public void ValidDayCalculation()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(1, 1));
            Assert.AreEqual("Вторник", ds.FindDayName(2, 1));
            Assert.AreEqual("Среда", ds.FindDayName(3, 1));
            Assert.AreEqual("Четверг", ds.FindDayName(4, 1));
            Assert.AreEqual("Пятница", ds.FindDayName(5, 1));
            Assert.AreEqual("Суббота", ds.FindDayName(6, 1));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7, 1));
        }

        [TestMethod]
        public void InvalidInput()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Invalid input", ds.FindDayName(-1, -1));
            Assert.AreEqual("Invalid input", ds.FindDayName(368, 369));
            Assert.AreEqual("Invalid input", ds.FindDayName(0, 1));
            Assert.AreEqual("Invalid input", ds.FindDayName(1, 8));
        }
    }
}