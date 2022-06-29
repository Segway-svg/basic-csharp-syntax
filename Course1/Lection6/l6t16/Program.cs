using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t16
{
    /*
     * Внутри метода Main() объявлен массив arr из 20 чисел. В методе Main() созданы еще два массива целых чисел, каждый размером на 10 чисел.
     * Разделите исходный массив arr на два массива: половину чисел добавьте в первый созданный массив, вторую половину во второй.
     * Выведите на экран содержимое двух созданных массивов, каждый с новой строки. Все элементы массива должны выводится одной строкой
     * разделённые пробелом. Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            /* Добавьте свой код ниже */
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = arr[i];
                arr2[i] = arr[10 + i];
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"{arr1[i]}");
                if (i == arr1.Length - 1) Console.WriteLine();
                else Console.Write(" ");
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($"{arr2[i]}");
                if (i == arr2.Length - 1) continue;
                else Console.Write(" ");
            }

        }   
    }
}
