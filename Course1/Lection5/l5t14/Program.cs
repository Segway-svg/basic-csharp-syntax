using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t14
{
    /*
     * Внутри метода Main() реализуйте программу, которая:
     *      1) Считывает целое число N, введенное с клавиатуры.
     *      2) Считывает N раз целые числа, введенные с клавиатуры.
     *      3) Выводит на экран наименьшее из введенных чисел (число N не должно учитываться).
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int n = Convert.ToInt32(Console.ReadLine());
            int answer = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int compare = Convert.ToInt32(Console.ReadLine());
                if (answer > compare)  answer = compare;
            }
            Console.WriteLine(answer);
        }
    }
}
