using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t12
{
    /*
     * Реализуйте статический метод DivisionBy(), который принимает два целых числа и возвращает результат деления первого на второе.
     * Внутри метода Main() вызовите метод DivisionBy(), передав ему в качестве аргумента два числа, введенные с клавиатуры.
     * Реализуйте запрос ввода чисел с клавиатуры таким образом, чтобы в случае если второе введенное число было равно нулю, то:
     *      1) На экран выводилась фраза "Делить на ноль НЕЛЬЗЯ!!! Пожалуйста введите другое число".
     *      2) Повторяли считывание второго числа до тех пор, пока не будет введено корректное значение.    
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            while (true)
            {
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 0)
                {
                    Console.WriteLine($"Делить на ноль НЕЛЬЗЯ!!! Пожалуйста введите другое число");
                    continue;
                }
                break;
            }
            Console.WriteLine(DivisionBy(a, b));
        }

        public static int DivisionBy(int a, int b)
        {
            /* Добавьте свой код ниже */
            return a / b;
        }
    }
}
