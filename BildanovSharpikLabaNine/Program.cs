using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BildanovSharpikLabaNine.Class1;

namespace BildanovSharpikLabaNine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите количество элементов массива: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Введите значение k1: ");
                int k1 = int.Parse(Console.ReadLine());
                Console.Write("Введите значение k2: ");
                int k2 = int.Parse(Console.ReadLine());
                double[] x = new double[n]; // объявляем массив x
                ReadValues(x, k1, k2); // вводим значения элементов массива x с индексами от k1 до k2
                FillRandom(x, 0, n - 1 - (k2 - k1)); // заполняем оставшиеся элементы массива x случайными значениями
                Console.WriteLine("Массив x:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(x[i] + " ");
                }
                Console.WriteLine();
                double[] y = new double[n]; // объявляем массив y
                for (int i = 0; i < n; i++)
                {
                    try
                    {
                        y[i] = Func(x[i]); // вычисляем значение функции для элемента x[i] и записываем его в массив y
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message); // в случае ошибки выводим сообщение об ошибке
                    }
                }
                Console.WriteLine("Массив y:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(y[i] + " ");
                }
                Console.WriteLine();
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (x[i] >= -2 && x[i] <= 2 && y[i] >= -2 && y[i] <= 2)
                    {
                        Console.WriteLine("Точка (" + x[i] + ", " + y[i] + ") попадает в заштрихованную область.");
                        count++;
                    }
                }
                Console.WriteLine("Количество точек, попадающих в заштрихованную область: " + count);
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный формат ввода.");
            }
        }
    }
}
