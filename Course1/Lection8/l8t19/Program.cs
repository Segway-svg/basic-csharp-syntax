using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t19
{
    /*
     *  Создайте метод AllSimple(), который принимает целое число Х, а возвращает массив всех простых чисел от 0 до Х включительно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            //foreach (var num in AllSimple(100))
            //{
            //    Console.WriteLine(num);
            //}
        }

        public int[] AllSimple(int x)
        {
            List<int> list = new List<int>();
            int counter = 0;
            for (int i = 2; i <= x; i++)
            {
                for (int j = 1; j <= x; j++)
                {
                    if (i % j == 0) counter++;
                }
                if (counter == 2)
                    list.Add(i);
                counter = 0;
            }

            int[] result = new int[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                result[i] = list[i];
            }

            return result;
        }
    }
}
