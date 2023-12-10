using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Makarenko Danil, individual project";

            Console.Write("a = ");                                  // Ввод значений сторон треугольника с помощью консоли.
            double a = double.Parse(Console.ReadLine());            // Объявляю переменную для хранения значений сторон треугольника.
            Console.Write("b = ");                                  // Ввод значений сторон треугольника с помощью консоли.
            double b = double.Parse(Console.ReadLine());            // Объявляю переменную для хранения значений сторон треугольника.
            Console.Write("c = ");                                  // Ввод значений сторон треугольника с помощью консоли.
            double c = double.Parse(Console.ReadLine());            // Объявляю переменную для хранения значений сторон треугольника.

            double p, s;                                            // Объявляю переменные для хранения полупериметра и площади треугольника.
            if (a < b + c && b < a + c && c < a + b)                // Проверка существования треугольника по основному свойству: сумма двух сторон треугольника должна быть больше третьей стороны.
            {
                Console.WriteLine("Треугольник существует!");       // Если треугольник существует выводим это в консоль.
                p = (a + b + c) / 2;                                // Вычисление полупериметра треугольника.
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));     // Вычисление площади треугольника по формуле Герона.
                Console.WriteLine($"Площадь треугольника = {s:f2}");// Вывод площади треугольника в консоль. ":f2" значит, что после запятой будет 2 знака
            }
            else
                Console.WriteLine("Треугольник не существует!");    // Если треугольник не существует, то выводим это в консоль.

            Console.ReadKey();


















        }
    }
}
