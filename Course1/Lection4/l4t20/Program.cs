using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t20
{
    /*
     * Внутри метода Main() реализуйте следующую логику работы программы:
     *      1) Считайте с клавиатуры 4 целых числа.
     *      2) Выведите в консоль фразу "Количество отрицательных чисел: ХХХ, количество положительных чисел: ХХХ".
     * ХХХ - количество положительных и отрицательных чисел.
     * Число 0 - не положительное и не отрицательное, его при подсчете учитывать не нужно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int plus = 0;
            int minus = 0;
            if (a > 0) plus++;
            else if (a < 0) minus++;
            if (b > 0) plus++;
            else if (b < 0) minus++;
            if (c > 0) plus++;
            else if (c < 0) minus++;
            if (d > 0) plus++;
            else if (d < 0) minus++;
            Console.WriteLine($"Количество отрицательных чисел: {minus}, количество положительных чисел: {plus}");
        }
    }
}
