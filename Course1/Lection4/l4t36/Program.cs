using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t36
{
    /*
     * Измените приоритет выполнения операций в методе Main() таким образом, чтобы в результате выполнения метода
     * в консоль было выведено значение 10101.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 1;
            int b = 17;
            int z = 21;
            int c = 15;
            int q = 3;
            Console.WriteLine(2546 * q + (c * z - c * c) + 2 * 19 * (q + a) * b * z - 51891);  // Приоритет операций менять тут
        }
    }
}
