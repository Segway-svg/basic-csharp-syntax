using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t37
{
    /*
     *  В классе Program создайте 4 публичных статических метода:
     *      1) Метод Sum() должен принимать два целочисленных параметра и возвращать их сумму.
     *      2) Метод Dif() должен принимать два целочисленных параметра и возвращать их разность.
     *      3) Метод Mul() должен принимать два целочисленных параметра и возвращать их произведение.
     *      4) Метод OperationSwitcher() должен:
     *          - принимать  1 строку (операцию) и 2 числа (операнда);
     *          - возвращать результат выполнения полученной операции, используя обращение к другим созданным методам.
     *  Внутри метода Main() необходимо:
     *      1) Вывести в консоль 3 строки:
     *          Привет! Я твой первый калькулятор!
     *          Я умею складывать (команда - Sum) вычитать (команда - Dif) умножать (команда - Mul)!
     *          Введите сначала операцию, а затем два числа:
     *      2) Последовательно считать с клавиатуры операцию, а затем два числа и передать их методу OperationSwitcher().
     *      3) Вывести на экран результат операции в формате: «Результат операции равен: ХХХ», где ХХХ - результат работы метода OperationSwitcher().
     *  Если пользователь введет операцию, которой не существует – необходимо вывести на экран фразу «Такой операции нет! Попробуйте еще раз:»
     *  и повторно считать строку с клавиатуры до тех пор, пока не будет введено корректное значение.
     *  В случае если введена неправильная операция – считывать числа не нужно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine("Привет! Я твой первый калькулятор!" + '\n' + 
                "Я умею складывать (команда - Sum) вычитать (команда - Dif) умножать (команда - Mul)!" + '\n' +
                "Введите сначала операцию, а затем два числа:");
            bool check = false;
            while (check != true) {
                string operation = Console.ReadLine();
                if (operation == "Sum" || operation == "Dif" || operation == "Mul")
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Результат операции равен: {OperationSwitcher(operation, a, b)}"); 
                    check = true;
                }
                else Console.WriteLine("Такой операции нет! Попробуйте еще раз:");
            }
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Dif(int a, int b)
        {
            return a - b;
        }

        public static int Mul(int a, int b)
        {
            return a * b;
        }

        public static int OperationSwitcher(string operation, int a, int b)
        {
            switch (operation)
            {
                case "Sum":
                    return Sum(a, b);
                case "Dif":
                    return Dif(a, b);
                default:
                    return Mul(a, b);
            }
        }
    }
}
