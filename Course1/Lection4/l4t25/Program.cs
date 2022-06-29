using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t25
{
    /*
     * Выведите в консоль все четные числа в диапазоне от 1 до 100. Все числа выведите в 1 строку, разделив пробелом.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0) Console.Write(i + " ");
            }
            Console.Write(100);
        }
    }
}
