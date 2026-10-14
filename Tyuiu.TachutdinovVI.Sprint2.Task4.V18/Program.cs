using System;
using Tyuiu.TachutdinovVI.Sprint2.Task4.V18.Lib;

namespace Tyuiu.TachutdinovVI.Sprint2.Task4.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Тачутдинов В. И. | ИСТНб-26-1";

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                       *");
            Console.WriteLine("* Тема: Тернарный оператор                                                        *");
            Console.WriteLine("* Задание #4                                                                      *");
            Console.WriteLine("* Вариант #18                                                                     *");
            Console.WriteLine("* Выполнил: Тачутдинов В. И. | ИСТНб-26-1                                        *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                        *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием       *");
            Console.WriteLine("* тернарного оператора, где пользователь вводит значения переменных X и Y        *");
            Console.WriteLine("* с клавиатуры.                                                                   *");
            Console.WriteLine("* Если 3 * X < Y - 2, то:                                                        *");
            Console.WriteLine("* Z = (6 + (X - 1) / Y^3)^X                                                     *");
            Console.WriteLine("* Иначе: Z = X + 10 * Y - 1 / X                                                  *");
            Console.WriteLine("* Ответ округлить до трех знаков после запятой.                                   *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                *");
            Console.WriteLine("***********************************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                      *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("Значение функции Z: " + res.ToString("F3"));
            Console.WriteLine("***********************************************************************************");

            Console.ReadKey();
        }
    }
}