using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t6
{
    /*
     * Внутри метода Main() объедините 2 коллекции - listA и listB, результат объединения поместите в третью коллекцию listX.
     * Сначала должны идти элементы коллекции listB, а затем коллекции listA. Коллекция listX не должна содержать элементов,
     * которые одновременно присутствуют в обеих исходных коллекциях. Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static List<int> listA = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
        public static List<double> listB = new List<double>() { 1, 2.2, 3.0, 4.4, 5, 6, 9.1, 10.2, 11.2, 3, 10.1, 10.2 };
        public static List<float> listX = new List<float>() { };

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            foreach (var curr in listA.ToArray())
            {
                if (listB.Contains(curr))
                {
                    listB.RemoveAll(num =>
                    {
                        if (num == curr)
                            return true;
                        else
                            return false;
                    });
                    listA.RemoveAll(num =>
                    {
                        if (num == curr)
                            return true;
                        else
                            return false;
                    });
                }
            }
            //    for (int i = 0; i < listA.Count; i++)
            //    {
            //    if (listB.Contains(listA[i]))
            //    {
            //        listB.RemoveAll(num =>
            //        {
            //            if (num == listA[i])
            //                return true;
            //            else
            //                return false;
            //        });
            //        listA.RemoveAll(num =>
            //        {
            //            if (num == listA[i])
            //                return true;
            //            else
            //                return false;
            //        });
            //    }
            //}

            for (int i = 0; i < listA.Count; i++)
            {
                listB.Add(listA[i]);
            }

            for (int i = 0; i < listB.Count; i++)
            {
                listX.Add((float)listB[i]);
            }


            //foreach (var num in listX) Console.WriteLine(num);

            //List<int> arr = new List<int> { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    if (arr.Contains(arr[i])) Console.WriteLine("AAA");
            //}
        }
    }
}
