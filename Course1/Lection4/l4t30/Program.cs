using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t30
{
    /*
     * В классе Program реализуйте статический метод GetRandomInt() так, чтобы он возвращал случайное
     * положительное трехзначное число, оканчивающееся на ноль.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetRandomInt());
        }

        public static int GetRandomInt()
        {
            /* Добавьте свой код ниже */
            Random random = new Random();
            return random.Next(10, 100) * 10;
        }
        //static Random random = new Random();
    }
}
