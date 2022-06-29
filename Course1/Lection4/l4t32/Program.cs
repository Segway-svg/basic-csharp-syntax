using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t32
{
    /*
     * Внутри метода Main() необходимо дополнить шаблон таким образом, чтобы в консоль выводились только числа кратные 7.
     * Остальные элементы шаблона изменять нельзя. При решении задачи необходимо использовать ключевое слово continue.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++) // Добавьте свой код ниже
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                    Console.WriteLine(i);
                }
            }
        }
    }
}
