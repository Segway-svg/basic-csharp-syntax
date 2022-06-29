using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t25
{
    /*
     * Внутри метода Main() переверните массив arrInt (первый элемент становится последним, последний первым и т.д.) используя стек.
     * Выведите полученный массив на экран, каждый элемент с новой строки. Шаблон задачи изменять нельзя. Метод Main() должен
     * содержать переменную типа Stack, дополнительные переменные объявлять нельзя.
     */

    public class Program
    {
        public static int[] arrInt = new int[] { 123, 123, 12, 3, 1, 31, 23, 17, 12, 3, 1, 23, 4, 456, 77, 78, 9, 89, 6, 54, 3, 534, 5, 74, 5, 32, 2, 42, 3, 5, 6, 3, 7 };

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Stack ts = new Stack();
            for (int i = 0; i < arrInt.Length; i++)
            {
                ts.Push(arrInt[i]);
            }

            for (int i = 0; i < arrInt.Length; i++)
            {
                arrInt[i] = (int)ts.Pop();
            }

            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.WriteLine(arrInt[i]);
            }
        }
    }
}
