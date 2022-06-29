using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t17
{
    /*
     * Создайте статический метод GetMinimum(), который принимает четыре целых числа и возвращает наименьшее из них.
     * Внутри метода Main() 3 раза выведите в консоль результат вызовов метода GetMinimum() в следующем формате:
     * "Самое маленькое число: ХХХ", где ХХХ - результат вызова метода GetMinimum().
     * Каждый из выводов результата работы метода GetMinimum() должен осуществляться с новой строки и с различными аргументами.
     * Если числа равны - выведите любое из них.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine($"Самое маленькое число: {GetMinimum(1, 2, 3, 4)}");
            Console.WriteLine($"Самое маленькое число: {GetMinimum(4, 4, 4, 4)}");
            Console.WriteLine($"Самое маленькое число: {GetMinimum(8, 7, 6, 5)}");
        }
        public static int GetMinimum(int a, int b, int c, int d)
        {
            if (a < b && a < c && a < d) return a;
            else if (b < a && b < c && b < d) return b;
            else if (c < a && c < b && c < d) return c;
            else return d;
        }
    }
}
