using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t18
{
    /*
     * Добавьте в класс Program статический метод MinutesToSeconds(), который принимает количество минут, а возвращает количество секунд. 
     * Внутри метода Main() вызовите метод MinutesToSeconds(), передав ему число 152 в качестве аргумента, результат вызова выведите в консоль.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(MinutesToSeconds(152)); 
        }
        /* Добавьте свой код ниже */
        static int MinutesToSeconds(int minutes)
        {
            return minutes * 60;
        }
    }
}
