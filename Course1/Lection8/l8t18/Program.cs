using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t18
{
    /*
     * Создайте метод GetOrder(), который должен:
     *      1) Принимать целое число.
     *      2) Возвращать произведение количества четных и нечетных цифр в принятом числе.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public int GetOrder(int num)
        {
            int even = 0;
            int odd = 0;
            if (num < 0) num *= -1;
            while (num > 0)
            {
                if (num % 10 % 2 == 0) even++;
                else odd++;
                num /= 10;
            }
            return even * odd;
        }
    }
}
