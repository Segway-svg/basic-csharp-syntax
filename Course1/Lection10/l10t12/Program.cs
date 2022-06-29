using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t12
{
    /*
     * Реализуйте метод Swapper(), который:
     *      1) Принимает большое целое число в качестве входящего параметра.
     *      2) Если принятое число состоит только из нулей и единиц, то преобразует число следующим образом: все нули становятся единицами, а единицы нулями.
     *      3) Если принятое число 0 или отрицательное, то возвращает ноль.
     *      4) Во всех остальных случаях возвращет число, записанное задом наперед.
     * ======================================================================================================================================================
     *      Пример: получил 0 - вернул 0;
     *      Пример: получил -100 - вернул 0;
     *      Пример: получил 10000101 - вернул 01111010;
     *      Пример: получил 123 - вернул 321;
     * ======================================================================================================================================================
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Swapper(0));
            Console.WriteLine(Swapper(-100));
            Console.WriteLine(Swapper(10000101));
            Console.WriteLine(Swapper(123));
        }

        /* Добавьте свой код ниже */
        public static long Swapper(long num)
        {
            /* Добавьте свой код ниже */
            if (num <= 0) { return 0; }
            
            string myStringNumber = num.ToString();
            for (int i = 0; i < myStringNumber.Length; i++)
            {
                if (myStringNumber[i] != '0' && myStringNumber[i] != '1')
                {
                    return long.Parse(new string(myStringNumber.Reverse().ToArray()));
                }
            }

            myStringNumber = myStringNumber.Replace('0', '_');
            myStringNumber = myStringNumber.Replace('1', '0');
            myStringNumber = myStringNumber.Replace('_', '1');
            return long.Parse(myStringNumber);
        }
    }
}
