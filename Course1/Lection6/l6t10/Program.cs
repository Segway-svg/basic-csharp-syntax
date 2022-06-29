using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t10
{
    /*
     * Измените шаблон таким образом, чтобы безопасно парсить число из строки, используя метод TryParse структуры Int32.
     * Если введено число - выведите его на экран, в противном случае выведите на экран фразу "Ошибка парсинга!".
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int a;
            if (Int32.TryParse(Console.ReadLine(), out a)) Console.WriteLine(a);
            else Console.WriteLine("Ошибка парсинга!");
        }
    }
}
