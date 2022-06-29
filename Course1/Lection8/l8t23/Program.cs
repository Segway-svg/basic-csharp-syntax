using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t23
{
    /*
     * Создайте статический метод GetMostCommonElement(), который должен принимать массив строк и возвращать
     * наиболее часто встречающийся элемент массива. Если таких элементов несколько - выведите тот, 
     * который имееет наименьший индекс первого элемента. Внутри метода Main() выведите на экран результат 
     * вызова метода GetMostCommonElement(), передав значение входящего параметра метода Main() в качестве аргумента.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            //string[] cars = { "Mazda", "Volvo", "Volvo", "BMW", "Ford", "Volvo", "Mazda", "Mazda" };
            Console.WriteLine(GetMostCommonElement(args)); 
        }
        /* Добавьте свой код ниже */
        public static string GetMostCommonElement(string[] arr)
        {
            int firstCounter = 1;
            int secondCounter = 1;
            int id = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        firstCounter++;
                    }
                    if (firstCounter > secondCounter)
                    {
                        secondCounter = firstCounter;
                        id = i;
                    }
                }
                firstCounter = 1;
            }
            return arr[id];
            //    ArrayList list = new ArrayList();
            //    List<int> counters = new List<int>();
            //    List<int> indexes = new List<int>();

            //    int counter = 0;

            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (!list.Contains(arr[i]))
            //        {
            //            list.Add(arr[i]);
            //            for (int j = 0; j < arr.Length; j++)
            //            {
            //                if (arr[i] == arr[j]) counter++;   
            //            }
            //            counters.Add(counter);
            //            indexes.Add(i);
            //            counter = 0;
            //        }
            //    }

            //    int maxCounter = 0;
            //    int maxIndex = 0;
            //    for (int i = 0; i < counters.Count - 1; i++)
            //    {
            //        if (counters[i] > maxCounter)
            //        {
            //            maxCounter = counters[i];
            //            maxIndex = i;
            //        }
            //    }

            //    for (int i = 0; i < counters.Count - 1; i++)
            //    {
            //        if (counters[i] == maxCounter)
            //        {
            //            if (indexes[i] < maxIndex)
            //            {
            //                maxIndex = indexes[i];
            //            }
            //        }
            //    }
            //    return arr[maxIndex];
        }
    }
}
