using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t11
{
    /*
     * Внутри метода Main() содержится список чисел intList. Считайте с клавиатуры 3 числа и
     * если они имеются в intList, то замените их на число 777 и сохраните на той же позиции в списке.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 1, 42, 3, 24, 5, 6, 57, 8, 9, 10, 123, 65, 123, 56, 7, 16, 17 };
            /* Добавьте свой код ниже */
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] == num1 || intList[i] == num2 || intList[i] == num3)
                    intList[i] = 777;
            }

            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }
        }
    }
}
