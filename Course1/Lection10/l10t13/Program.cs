using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t13
{
    /*
     * Создайте метод IsInDegree(), который:
     *      1) Принимает большое целое число в качестве входящего параметра.
     *      2) Возвращает логическое значение: true - если принятое число является числом 2 в целой степени и false если нет.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        /* Добавьте свой код ниже */
        public bool IsInDegree(long num)
        {
            for (long x = 1; x <= num; x *= 2)
            {
                if (x == num)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
