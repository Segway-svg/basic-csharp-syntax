using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t35
{
    /*
     * Метод Main() необходимо дополнить таким образом, чтобы в результате работы программы было выведено число 9 и только 1 раз.
     * Исходный шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                /* Добавьте свой код ниже */
                i = 9;
                Console.WriteLine(i);
                i = 10;
                if (i == 10)
                {
                    break;
                }
            }
        }
    }
}
