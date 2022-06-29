using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t33
{
    /*
     * Внутри класса Program создайте 5 целочисленных переменных, которые бы отвечали за:
     *      1) Количество положительных чисел (positive).
     *      2) Количество отрицательных чисел (negative).
     *      3) Количество четных чисел (even).
     *      4) Количество нечётных чисел (odd).
     *      5) Количество НЕ чисел (notNumber).
     * Создайте и реализуйте метод класса MyCustomCounter(), который должен считывать
     * 10 строк с клавиатуры, анализировать их и увеличивать значения соответствующих переменных класса Program.
     * Внутри метода Main() добавьте вызов метода MyCustomCounter(), после чего последовательно выведите на экран значения
     * всех созданных переменных класса Program в следующем формате:
     *      Количество положительных чисел: ХХХ.
     *      Количество отрицательных чисел: ХХХ.
     *      Количество чётных чисел: ХХХ.
     *      Количество нечётных чисел: ХХХ.
     *      Количество НЕ чисел: ХХХ.
     * где ХХХ - значения соответствующих переменных класса Program после вызова метода MyCustomCounter().
     * Все элементы класса Program должны быть публичными.
     */

    public class Program
    {
        public int positive = 0;
        public int negative = 0;
        public int even = 0;
        public int odd = 0;
        public  int notNumber = 0;
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Program program = new Program();
            program.MyCustomCounter();
            Console.WriteLine($"Количество положительных чисел: {program.positive}.");
            Console.WriteLine($"Количество отрицательных чисел: {program.negative}.");
            Console.WriteLine($"Количество чётных чисел: {program.even}.");
            Console.WriteLine($"Количество нечётных чисел: {program.odd}.");
            Console.WriteLine($"Количество НЕ чисел: {program.notNumber}.");
        }
        public void MyCustomCounter()
        {
            for (int i = 0; i < 10; i++)
            {
                string obj = Console.ReadLine();
                if (Int32.TryParse(obj, out int check))
                {
                    int num = Convert.ToInt32(obj);
                    if (num > 0) positive++;
                    if (num < 0) negative++;
                    if (num % 2 == 0) even++;
                    if (num % 2 != 0) odd++;
                }
                else notNumber++;
            }
        }
    }
}
