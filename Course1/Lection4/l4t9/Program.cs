using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t9
{
    /*
     * Создайте метод CheckInterval(), который должен принимать целое число и выводить в консоль:
     *   1) "Число ХХХ не содержится в интервале.", если число не входит в интервал от 30 до 100 включительно.
     *   2) "Число ХХХ содержится в интервале.", если число входит в интервал от 30 до 100 включительно.
     * ХХХ - значение, переданное при вызове метода CheckInterval().
     * Внутри метода Main() вызовите метод CheckInterval() 4 раза, передав ему в качестве аргумента:
     *   1) 10.
     *   2) 30.
     *   3) 1000.
     *   4) 100.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Program program = new Program();
            program.CheckInterval(10);
            program.CheckInterval(30);
            program.CheckInterval(1000);
            program.CheckInterval(100);
        }
        void CheckInterval(int num)
        {
            if (num < 30 || num > 100) Console.WriteLine($"Число {num} не содержится в интервале.");
            if (num >= 30 && num <= 100) Console.WriteLine($"Число {num} содержится в интервале.");
        }
    }
}