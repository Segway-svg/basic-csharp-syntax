using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t6
{
    /*
     * Реализуйте метод MakeIntArray(), который должен возвращать массив из N чисел, заполненный
     * случайными целыми числами от 1 до 100 включительно.
     * Реализуйте метод MakeCustomIntArray(), который должен:
     *      1) Принимать в себя массив целых чисел и параметр А.
     *      2) Выводить на экран все элементы полученного массива, которые меньше или равны параметру А. Каждый элемент с новой строки.
     *      3) Иметь исходящий параметр, с количеством элементов, удовлетворяющих данному условию.
     * Внутри метода Main() вызовите метод MakeCustomIntArray(), передав ему в качестве аргументов произвольное число и
     * результат вызова метода MakeIntArray(). Присвойте переменной r исходящий параметр метода MakeCustomIntArray().
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int r;
            Program program = new Program();
            program.MakeCustomIntArray(program.MakeIntArray(100), 50, out r);
            Console.WriteLine(r);
        }
        /* Добавьте свой код ниже */
        public void MakeCustomIntArray(int[] array, int A, out int count)
        {
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= A)
                {
                    Console.WriteLine(array[i]);
                    count++;
                }
            }
        }
        public int[] MakeIntArray(int N)
        {
            Random random = new Random();
            int[] array = new int[N];
            for (int i = 0; i < array.Length; i++) array[i] = random.Next(1, 101);
            return array;
        }
    }
}
