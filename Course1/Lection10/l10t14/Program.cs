using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace l10t14
{
    /*
     * Реализуйте метод BigIntegerCalculator(), который:
     *      1) Принимает два больших целых числа в качестве входящих параметров.
     *      2) Возвращает строку, содержащую сумму принятых больших целых чисел.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }
        public string BigIntegerCalculator(long a, long b)
        {
            if (a >= 0 || b >= 0)
            {
                ulong sum = (ulong)a + (ulong)b;
                return Convert.ToString(sum);
            }
            else
            {
                return Convert.ToString(a + b);
            }

            //BigInteger sum = (BigInteger)a + b;
            //return Convert.ToString(sum);
        }
    }
}
