
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TachutdinovVI.Sprint2.Task4.V18.Lib
{
    public class DataService : ISprint2Task4V18
    {
        public double Calculate(double x, double y)
        {
            double z = 3 * x < y - 2
                ? Math.Pow(6 + (x - 1) / Math.Pow(y, 3), x)
                : x + 10 * y - (1.0 / x);

            return Math.Round(z, 3);
        }
    }
}