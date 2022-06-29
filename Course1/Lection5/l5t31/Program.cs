using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t31
{
    /*
     * Создайте публичный статический класс SimpleSupportClass в том же файле и namespace что и класс Program.
     * Добавьте в созданный класс 3 приватных поля и 3 свойства. Название и типы могут быть произвольными.   
     */

    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    /* Добавьте свой код ниже */
    public static class SimpleSupportClass
    {
        private static string name;
        private static int age;
        private static string address;

        private static int Speed { get; set; }
        private static string Color { get; set; }
        private static int tailsCount { get; set; }

    }
}
