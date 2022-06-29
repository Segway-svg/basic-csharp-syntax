using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t5
{
    /*
     * Внутри метода Main() выведите в консоль значения переменных b и s в следующем формате:
     * "Значение переменной b = XXX, а значение переменной s = YYY!", 
     * где XXX и YYY - значения соответствующих переменных.
     * 
     * P.S. Не забудьте про пробелы и знаки препинания =)
     */

    public class Program
    {
        static int b = 111;
        static string s = "222";

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine($"Значение переменной b = {b}, а значение переменной s = {s}!");
        }
    }
}
