using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t34
{
    /*
     * Внутри класса Program создайте и реализуйте публичный метод GetMoreInformation(), который:
     *      1) Принимает 1 целочисленный параметр.
     *      2) Выводит в консоль информацию о полученном числе в следующем формате:
     *         "Число ХХХ отрицательное\положительное! Число состоит из N цифр!",
     *         где ХХХ - значение полученного параметра, N - количество цифр в полученном числе.
     *      3) Если введённое число ноль - метод ничего не должен выводить в консоль.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Program program = new Program();
            program.GetMoreInformation(5);

        }
        public void GetMoreInformation(int num)
        {
            int counter = 0;
            int answer = num;
            while (num != 0)
            {
                num /= 10;
                counter++;
            }
            if (answer > 0)
            {
                Console.WriteLine($"Число {answer} положительное! Число состоит из {counter} цифр!");
            }   
            else if (answer < 0)
            {
                Console.WriteLine($"Число {answer} отрицательное! Число состоит из {counter} цифр!");
            }
        }
    }
}
