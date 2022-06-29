using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t32
{
    /*
     * Создайте публичный статический класс SupportPrinterClass в том же файле и namespace что и класс Program.
     * Добавьте в созданный класс 4 публичных метода:
     *      1) Printer, который должен принимать в качестве входящего параметра строку и выводить её на экран 1 раз.
     *      2) DoublePrinter, который должен принимать в качестве входящего параметра строку и выводить её на экран 2 раза.
     *      3) TriplePrinter, который должен принимать в качестве входящего параметра строку и выводить её на экран 3 раз.
     *      4) MultiPrinter, который должен принимать в качестве входящего параметра строку и число раз, которое её надо вывести на экран.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
    /* Добавьте свой код ниже */
    public static class SupportPrinterClass
    {
        public static void Printer(string str)
        {
            Console.WriteLine(str);
        }

        public static void DoublePrinter(string str)
        {
            Console.WriteLine(str);
            Console.WriteLine(str);
        }

        public static void TriplePrinter(string str)
        {
            Console.WriteLine(str);
            Console.WriteLine(str);
            Console.WriteLine(str);
        }

        public static void MultiPrinter(string str, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(str);
            }
        }
    }
}
