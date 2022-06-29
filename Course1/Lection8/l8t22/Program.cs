using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t22
{
    /*
     * Создайте статический метод GetRoundCount() который принимает целое число и возвращает количество замкнутых фигур
     * в принятом числе.
     * ==========================================================================================================
     *  Например число 0 и 8 - имеют 2 замкнутых "кружка" и т.д.
     * ==========================================================================================================
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(GetRoundCount(-126)); 

        }
        public static int GetRoundCount(int num)
        {
            int counter = 0;
            if (num < 0) num *= -1;
            foreach (var ch in num.ToString())
            {
                if (ch == '4' || ch == '6' || ch == '9') counter++;
                if (ch == '0' || ch == '8') counter += 2;
            }
            return counter;
        }
    }
}
