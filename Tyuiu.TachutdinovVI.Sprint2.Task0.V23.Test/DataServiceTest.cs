using Tyuiu.TachutdinovVI.Sprint2.Task0.V23.Lib;

namespace Tyuiu.TachutdinovVI.Sprint2.Task0.V23.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod()
    {
        DataService ds = new();
        int x = 105, y = 795;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);

        bool[] wait = new bool[6] { true, false, true, true, false, true };
        CollectionAssert.AreEqual(wait, res);
    }
}