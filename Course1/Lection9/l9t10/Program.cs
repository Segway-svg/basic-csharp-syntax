using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t10
{
    /*
     * Создайте статический метод AllByZero(), который принимает целое число и выводит на экрана результат от деления принятого числа на ноль.
     * Внутри метода Main() вызовите метод AllByZero() и перехватите исключение. Выведите на экран стектрейс возникшего исключения.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            try
            {
                AllByZero(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
        public static void AllByZero(int num)
        {
            Console.WriteLine(num / 0);
        }
    }
}
