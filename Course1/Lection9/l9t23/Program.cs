using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t23
{
    /*
     * Реализуйте статический метод DivisionBy(), который принимает два целых числа и возвращает результат деления первого на второе.
     * Внутри метода Main() вызовите метод DivisionBy(), передав ему в качестве аргумента два числа, введенные с клавиатуры.
     * Реализуйте запрос ввода чисел с клавиатуры таким образом, чтобы в случае если второе введенное число было равно нулю, то:
     *      1) На экран выводилась фраза "Делить на ноль НЕЛЬЗЯ!!! Пожалуйста введите другое число".
     *      2) Повторяли считывание второго числа до тех пор, пока не будет введено корректное значение.
     * Если на любом из этапов ввода было введено некорректное значение, которое приведет к возникновению исключения, необходимо:
     *      1) На экран выводилась фраза "Введенное значение не является числом. Пожалуйста введите число".
     *      2) Повторяли считывание числа до тех пор, пока не будет введено корректное значение.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int a = 0;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Введенное значение не является числом. Пожалуйста введите число");
                bool counter = true;
                while (true)
                {
                    try
                    {
                        a = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Введенное значение не является числом. Пожалуйста введите число");
                        counter = false;
                    }
                    if (counter == true)
                    {
                        break;
                    }
                    counter = true;
                }
            }

            int b;
            string be = "";
            bool isZero = false;
            bool isDifNum = false;
            while (true)
            {
                be = Console.ReadLine();
                if (!int.TryParse(be, out int result))
                {
                    
                    Console.WriteLine("Введенное значение не является числом. Пожалуйста введите число");
                        
                    
                }

                if (be == "0")
                {
                    
                    Console.WriteLine("Делить на ноль НЕЛЬЗЯ!!! Пожалуйста введите другое число");
                    
                }

                if (be != "0" && int.TryParse(be, out int res))
                {
                    break;
                }
            }
            b = Convert.ToInt32(be);
            Console.WriteLine(DivisionBy(a, b));
        }


        public static int DivisionBy(int a, int b)
        {
            /* Добавьте свой код ниже */
            return a / b;
        }
    }
}
