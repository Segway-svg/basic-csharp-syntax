using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t27
{
    /*
     * Создайте статический метод GetCustomStack(), который:
     *      1) Принимает два стека строк.
     *      2) Возвращает стек строк, состоящий из элементов которые одновременно присутствовали в обоих принятых стеках.
     * Внутри метода Main() вызовите метод GetCustomStack(), передав ему в качестве аргумента переменные stackA и stackB.
     * Сохраните результат вызова в отдельную переменную и выведите все элементы получившегося стека на экран в одну строку
     * через пробел.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static Stack<string> stackA = new Stack<string>(new string[] { "s", "i", "m", "p", "l", "e", " " });
        public static Stack<string> stackB = new Stack<string>(new string[] { "s", "t", "r", "i", "n", "g", "s", " " });


        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            var s = GetCustomStack(stackA, stackB);
            for (int i = 0; i <= s.Count + 1; i++)
            {
                if (i == s.Count + 1)
                {
                    Console.Write(s.Pop());
                    break;
                }
                Console.Write(s.Pop() + " ");
            }

            // Почему вывод сработал при условии i <= s.Count + 1 в for?
        }
        /* Добавьте свой код ниже */
        public static Stack<string> GetCustomStack(Stack<string> stack1, Stack<string> stack2)
        {
            Stack<string> stack = new Stack<string>(stack1.Intersect(stack2));
            return stack;
        }
    }
}