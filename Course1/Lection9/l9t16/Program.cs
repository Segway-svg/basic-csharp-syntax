using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t16
{
    /*
     * Внутри метода Main() создайте список, который может содержать массив целых чисел. Добавьте в список 5 массивов длинной:
     *      1) 0.
     *      2) 7.
     *      3) 12.
     *      4) 8.
     *      5) 17.
     * Заполните эти массивы случайными числами и выведите значения всех элементов списка, каждое с новой строки.
     * При выводе элементов каждого из массивов списка, они должны выводиться в одну строку, разделенные пробелом. 
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            List<int[]> list = new List<int[]>();
            list.Add(new int[0]);
            list.Add(new int[7]);
            list.Add(new int[12]);
            list.Add(new int[8]);
            list.Add(new int[17]);            

            Random rnd = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Length; j++)
                {
                    list[i][j] = rnd.Next();      
                }
            }

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list[i].Length; j++)
                {
                    if (j == list[i].Length - 1)
                    {
                        Console.WriteLine(list[i][j]);
                        break;
                    }
                    Console.Write(list[i][j] + " ");
                }
            }
        }
    }
}
