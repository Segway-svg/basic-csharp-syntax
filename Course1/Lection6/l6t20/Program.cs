using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t20
{
    /*
     * Измените шаблон таким образом, чтобы при выводе переменных в консоль количество цифр после запятой совпадало с числом в названии переменной, содержащей это число.
     * Остальные элементы шаблона изменять нельзя, округление при выводе допустимо.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            double d0 = 89 / 7d;
            double d1 = 89 / 17d;
            double d7 = 300 / 3d;
            double d5 = 54d / d0;
            
            string zero = nameof(d0);
            string one = nameof(d1);
            string seven = nameof(d7);
            string five = nameof(d5);

            Console.WriteLine(Math.Round(d0, Convert.ToInt32(zero[1]) - 48));  //Измените меня!
            Console.WriteLine(Math.Round(d1, Convert.ToInt32(one[1]) - 48));  //Измените меня!
            Console.WriteLine(Math.Round(d7, Convert.ToInt32(seven[1]) - 48));  //Измените меня!
            Console.WriteLine(Math.Round(d5, Convert.ToInt32(five[1]) - 48));  //Измените меня!
        }
    }
}
