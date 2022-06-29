using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t22
{
    /*
     * Выведите в консоль квадрат 10 на 10, который состоит только из букв Ъ.
     * Для решения используйте цикл while.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int i = 1;
            while (i < 101)
            {
                Console.Write("Ъ");
                if (i % 10 == 0) Console.WriteLine();
                i++;
            }
        }
    }
}
