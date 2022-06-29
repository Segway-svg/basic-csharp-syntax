using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t17
{
    /*
     * Создайте статический метод GetDigitsSum(), которое принимает целое число, а возвращает сумму всех его цифр.
     * Метод GetDigitsSum() должен быть реализован рекурсивно. Использовать любые циклы запрещено.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(GetDigitsSum(0)); 
        }

        /* Добавьте свой код ниже */
        public static int GetDigitsSum(int num)
        {
            if (num < 0) num *= -1;
            if (num == 0)
                return 0;
            else     
                return num % 10 + GetDigitsSum(num / 10);
                //return (num + GetDigitsSum(num / 10) % 10) % 10;
        }
    }
}
