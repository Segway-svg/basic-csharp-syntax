using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t21
{
    /*
     * Создайте метод GetAllSum(), который принимает список массива целых чисел, а возвращает
     * произведение полных сумм всех его элементов.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
        }
        /* Добавьте свой код ниже */
        public int GetAllSum(List<int[]> arr)
        {
            int sum = 0;
            int allSum = 1;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum += arr[i][j];
                }
                allSum *= sum;
                sum = 0;
            }
            return allSum;
        }
    }
}
