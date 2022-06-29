using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t26
{
    /*
     * Создайте статический метод GetRandomList, который принимает целое число X и возвращает список целых чисел длинной X,
     * заполненный случайными числами от 1 до 100. Внутри метода Main() сохраните результат вызова метода GetRandomList
     * в переменную соответствующего типа, после чего создайте новый стек (Stack), поместив в него все элементы полученного списка.
     * Аргумент при вызове считайте с консоли.
     * Выведите попарно элементы обоих списков (каждый с новой строки) в следующем формате:
     * "ХХХ – YYY", где ХХХ - элемент списка, YYY - элемент стека.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            List<int> randomNums = GetRandomList(Convert.ToInt32(Console.ReadLine()));
            Stack ts = new Stack();
            for (int i = 0; i < randomNums.Count; i++)
            {
                ts.Push(randomNums[i]);
            }

            for (int i = 0; i < randomNums.Count; i++)
            {
                Console.WriteLine($"{randomNums[i]} – {ts.Pop()}");
            }
        }

        /* Добавьте свой код ниже */
        public static List<int> GetRandomList(int x)
        {
            List<int> randomNums = new List<int>();
            Random random = new Random();
            for (int i = 0; i < x; i++)
            {
                randomNums.Add(random.Next(1, 101));
            }
            return randomNums;
        }
    }
}
