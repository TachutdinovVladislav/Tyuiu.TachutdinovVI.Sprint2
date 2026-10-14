using Tyuiu.TachutdinovVI.Sprint2.Task5.V4.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x;
        Console.WriteLine("Введите номер масти:");
        x=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Масть карты - " + ds.FindCardSuit(x));
    }
}