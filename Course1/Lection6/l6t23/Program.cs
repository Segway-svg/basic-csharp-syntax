using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t23
{
    /*
     * Задан динамический массив arr, известно, что внутри массива arr имеются: строки, целые и дробные числа, логические значения.
     * Внутри метода Main() реализуйте следующую логику:
     *      1) Создайте 4 типизированных списка, в соответствии с возможными типами внутри динамического массива arr.
     *      2) Рассортируйте все элементы массива arr по соответствующим спискам в зависимости от типа элемента.
     *      3) Выведите на экран информацию о получившихся списках в следующем формате:
     * "Список целых чисел включает в себя ХХХ элементов.", где ХХХ - количество элементов соответствующего типа.
     * "Список строк включает в себя ХХХ элементов.", где ХХХ - количество элементов соответствующего типа.
     * "Список дробных чисел включает в себя ХХХ элементов.", где ХХХ - количество элементов соответствующего типа.
     * "Список логических значений включает в себя ХХХ элементов.", где ХХХ - количество элементов соответствующего типа.
     * Последней строкой выведите на экран общее количество элементов, которые содержались в динамическом массиве arr.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList arr = new ArrayList() { "ч", 1, 2, 3, "q", true, false, "й", 1.11, 2.2, 1d, 2d, 17, 17.0, 123, "int32", false, true };
            /* Добавьте свой код ниже */
            List<string> listStr = new List<string>();
            List<int> listInt = new List<int>();
            List<bool> listBool = new List<bool>();
            List<double> listDouble = new List<double>();
            foreach (object i in arr)
            {
                TypeCode typeCode = Type.GetTypeCode(i.GetType());
                if (typeCode == TypeCode.String) listStr.Add(Convert.ToString(i));
                if (typeCode == TypeCode.Int32) listInt.Add(Convert.ToInt32(i));
                if (typeCode == TypeCode.Boolean) listBool.Add(Convert.ToBoolean(i));
                if (typeCode == TypeCode.Double) listDouble.Add(Convert.ToDouble(i));
            }
            Console.WriteLine($"Список целых чисел включает в себя {listInt.Count} элементов.");
            Console.WriteLine($"Список строк включает в себя {listStr.Count} элементов.");
            Console.WriteLine($"Список дробных чисел включает в себя {listDouble.Count} элементов.");
            Console.WriteLine($"Список логических значений включает в себя {listBool.Count} элементов.");
            Console.WriteLine(arr.Count);
        }
    }
}