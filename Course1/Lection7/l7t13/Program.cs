using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t13
{
    /*
     * Реализуйте метод MyOwnSortMethod(), который должен принимать список целых чисел, а возвращать
     * их в виде списка целых чисел, отсортированного в порядке убывания. Методом Sort пользоваться нельзя.
     * Шаблон задачи изменять нельзя.  
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> originalList = new List<int>() { 12, 23, 123, 123, 545, 23, 12, 434567, 79, 89, 678, 56, 345, 233, 1290, 78, 567, 345, 12, 23, 577658, 987 };
            List<int> sortedList = MyOwnSortMethod(originalList);
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }

        private static List<int> MyOwnSortMethod(List<int> p)
        {
            /* Добавьте свой код ниже */
            for (int i = 0; i < p.Count; i++)
            {
                for (int j = i + 1; j < p.Count; j++)
                {
                    if (p[i] < p[j])
                    {
                        int tmp = p[i];
                        p[i] = p[j];
                        p[j] = tmp;
                    }
                }
            }
            return p;
        }
    }
}
