using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t15
{
    /*
     * Внутри метода Main() создайте программу, которая считывает 5 чисел с клавиатуры
     * и выводит в консоль наименьшее из них.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int answer = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                int compare = Convert.ToInt32(Console.ReadLine());
                if (answer > compare) answer = compare;
            }
            Console.WriteLine(answer);
        }
    }
}
