using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t13
{
    /*
     * Добавьте в класс Program статический метод MirrorTriplePrinter(), который 3 раза выводит 
     * в консоль фразу, введенную с клавиатуры, каждую с новой строки. 
     * Тип возвращаемого значения метода MirrorTriplePrinter() сделайте пустым.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
        }
        /* Добавьте свой код ниже */
        static void MirrorTriplePrinter()
        { 
            string answer = Console.ReadLine();
            Console.WriteLine(answer);
            Console.WriteLine(answer);
            Console.WriteLine(answer);
        }
    }
}
