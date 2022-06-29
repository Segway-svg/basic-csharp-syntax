using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t16
{
    /*
     * Создайте статический метод GetMaximum(), который принимает три целых числа и возвращает наибольшее из них.
     * Внутри метода Main() 3 раза выведите в консоль результат вызовов метода GetMaximum() в следующем формате:
     * "Самое большое число: ХХХ", где ХХХ - результат вызова метода GetMaximum().
     * Каждый из выводов результата вызова метода GetMaximum() должен осуществляться с новой строки и с различными аргументами.
     * Если числа равны - выведите любое из них.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine($"Самое большое число: {GetMaximum(1, 2, 3)}");
            Console.WriteLine($"Самое большое число: {GetMaximum(4, 4, 4)}");
            Console.WriteLine($"Самое большое число: {GetMaximum(7, 6, 5)}");
        }
        public static int GetMaximum(int a, int b, int c)
        {
            if (a > b && a > c) return a;
            else if (b > a && b > c) return b;
            else return c;
        }
    }
}
