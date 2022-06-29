using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t11
{
    /*
     * Создайте статический метод DivisionBy(), который принимает два целых числа и возвращает результат деления первого на второе.
     * Добавьте в метод проверку второго аргумента на равенства нулю. Если он равен нулю, то необходимо выбросить соответствующее
     * исключение.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(DivisionBy(2, 3)); 

        }
        public static double DivisionBy(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return ((double)a / b);
        }
    }
}
