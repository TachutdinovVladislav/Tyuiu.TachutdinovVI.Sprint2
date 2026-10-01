using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.TachutdinovVI.Sprint2.Task1.V3.Lib
{
    public class DataService : ISprint2Task1V3
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            return [c == d | a > b , a > b & d < c ,c == b || c != d,b <= a && b > d,!(b > c),c == d ^ a < b];
        }
    }
}