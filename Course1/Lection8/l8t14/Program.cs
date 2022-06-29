using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t14
{
    /*
     * Создайте статический метод CalcDegree(), который принимает два целых числа  А и B, а возвращает значение числа А в степени B.
     * Метод CalcDegree должен быть реализован итеративно.
     * Внутри метода Main() добавьте вывод в консоль результат значения метода CalcDegree() для следующих аргументов:
     *      1) 5 и 5
     *      2) 1 и 0
     *      3) 15 и 4
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(CalcDegree(5, 5)); 
            Console.WriteLine(CalcDegree(1, 0)); 
            Console.WriteLine(CalcDegree(15, 4)); 
        }

        /* Добавьте свой код ниже */
        public static int CalcDegree(int a, int b)
        {
            if (b == 0) return 1;
            int constantA = a;
            for (int i = 1; i < b; i++)
            {
                a *= constantA;
            }
            return a;
        }
    }
}
