using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t25
{
    /*
     * Реализуйте метод LookMomNoHands(), который должен возвращать массив, в котором все элементы столбцов принятого массива 
     * отсортированы в порядке возрастания элементов. Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int[][] arr = new int[5][];
            arr[0] = new int[] { 1, 2, 1, 0, 7 };
            arr[1] = new int[] { 2, 4, 1, 5, 7 };
            arr[2] = new int[] { 3, 1, 7, 3, 2 };
            arr[3] = new int[] { 0, 3, 8, 1, 1 };
            arr[4] = new int[] { 4, 5, 3, 0, 2 };
            arr = LookMomNoHands(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[0].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[][] LookMomNoHands(int[][] arr)
        {
            /* Добавьте свой код ниже */
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[0].Length; j++)
                {
                    for (int k = j + 1; k < arr[i].Length; k++)
                    {
                        if (arr[j][i] > arr[k][i])
                        {
                            int tmp = arr[j][i];
                            arr[j][i] = arr[k][i];
                            arr[k][i] = tmp;
                        }
                    }
                }
            }
            return arr;
        }
    }
}
