using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BildanovSharpikLabaNine
{
    internal class Class1
    {
        public static double Func(double x)
        {
            int A = new Random().Next(-50, 51); // вычисляем случайное значение A
            if (double.IsNaN(x))
                throw new ArgumentException("Некорректное значение параметра x.");
            if (double.IsInfinity(x))
                throw new ArgumentException("Параметр x имеет бесконечное значение.");
            if (x < 0)
                return x + Math.Pow(Math.Sin(1 / x - A + 4), 2);
            else
                return A * x / Math.Sqrt(Math.Pow(A, 2) - Math.Pow(x, 2));
        }
        public static void ReadValues(double[] arr, int k1, int k2)
        {
            for (int i = k1; i <= k2; i++)
            {
                Console.Write("Введите значение элемента с индексом " + i + ": ");
                arr[i] = double.Parse(Console.ReadLine());
            }
        }
        public static void FillRandom(double[] arr, int k1, int k2)
        {
            Random rnd = new Random();
            for (int i = k1; i <= k2; i++)
            {
                arr[i] = rnd.NextDouble() * 100 - 50; // заполняем случайными значениями в диапазоне от -50 до 50
            }
        }
    }
}
