using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t3
{
    /*
     * Внутри метода Main() объявите три переменные типа string. Первой переменной 
     * присвойте значение "Васька", второй - "кота зовут", а третьей - "Моего любимого".
     * Выведите на экран фразу "Моего любимого кота зовут Васька" в одну строку.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            string first = "Васька";
            string second = "кота зовут";
            string third = "Моего любимого";
            Console.WriteLine(third + " " + second + " " + first);

        }
    }
}
