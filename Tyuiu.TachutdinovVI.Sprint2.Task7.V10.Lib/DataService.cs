
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TachutdinovVI.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = (y >= Math.Pow(x, 2) - 2) &&
                       (y <= Math.Abs(x));

            return res;
        }
    }
}
