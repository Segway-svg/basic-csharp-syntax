using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t13
{
    /*
     * Внутри метода Main() реализуйте следующую логику работы программы:
     *      1) Объявите 3 переменные и присвойте им значения, считанные с клавиатуры.
     *      2) Если среди введенных значений есть одинаковые, то необходимо вывести их на экран через пробел.
     *      3) Выведите в консоль фразу "Все разные", если все 3 переменные содержат различные значения.
     *      4) Если все 3 переменные одинаковые, то выведите их все в консоль через запятую.
     * Тип и имена переменных определите самостоятельно.
     */
    
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            if (a != b && b != c && a != c) Console.WriteLine("Все разные");
            if (a == b && b == c && a == c) Console.WriteLine(a + "," + b + "," + c);
            else
            {
                if (a == b) Console.Write(a + " " + b);
                if (b == c) Console.WriteLine(b + " " + c);
                if (a == c) Console.WriteLine(a + " " + c);
            }
        }
    }
}
