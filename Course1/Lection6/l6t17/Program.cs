using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t17
{
    /*
     * Реализуйте метод GetArrayFromConsole(). Метод должен:
     *      1) Принимать число N в качестве входящего параметра.
     *      2) Создавать массив из N элементов и заполнять его строками, считанными с клавиатуры.
     *      3) Возвращать созданный массив строк из N элементов.
     * Если передано число N меньше 1, то размер возвращаемого массива должен быть равен 1.
     * Если передано число больше 10, то размер возвращаемого массива должен быть равен 10.
     * Внутри метода Main() выведите на экран информацию о массиве arr в следующем формате:
     *      1) "Количество элементов массива: ХХХ"
     *      2) "Минимальная длина элемента массива: ХХХ"
     *      3) "Максимальная длина элемента массива: ХХХ"
     * Выведите на экран 5 и 10 элемент массива. Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] arr = GetArrayFromConsole(10);
            /* Добавьте свой код ниже */
            Console.WriteLine($"Количество элементов массива: {arr.Length}");
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length < min) min = arr[i].Length;
            }
            Console.WriteLine($"Минимальная длина элемента массива: {min}");
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > max) max = arr[i].Length;
            }
            Console.WriteLine($"Максимальная длина элемента массива: {max}");
            Console.WriteLine(arr[4]);
            Console.WriteLine(arr[9]);
        }

        public static string[] GetArrayFromConsole(int x)
        {
            /* Добавьте свой код ниже */
            if (x < 1) x = 1;
            if (x > 10) x = 10;
            string[] arr = new string[x];

            for (int i = 0; i < x; i++) arr[i] = Console.ReadLine();
            return arr;
            //return null;
        }
    }
}
