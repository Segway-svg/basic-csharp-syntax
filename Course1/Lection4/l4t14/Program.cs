using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t14
{
    /*
     * Создайте статический метод GetMinimum() который принимает два целых числа и возвращает наименьшее из них.
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
            Console.WriteLine($"Самое маленькое число: {GetMinimum(1, 3)}");
            Console.WriteLine($"Самое маленькое число: {GetMinimum(2, 2)}");
            Console.WriteLine($"Самое маленькое число: {GetMinimum(6, 5)}");
        } 
        public static int GetMinimum(int a, int b)
        {
            if (a < b) return a;
            else return b;
        }
    }
}
