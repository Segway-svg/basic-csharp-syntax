using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t28
{
    /*
     * Создайте статический метод GetFreshStack(), который:
     *      1) Принимает два стека строк.
     *      2) Возвращает стек строк в который должны быть включены по одному разу элементы, которые входят в stackA, но не входят в стек stackB.
     * Внутри метода Main() вызовите метод GetFreshStack(), передав ему в качестве аргумента переменные stackA и stackB.
     * Сохраните результат вызова в отдельную переменную и выведите все элементы получившегося стека на экран в одну строку через пробел.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static Stack<string> stackA = new Stack<string>(new string[] { "l", "o", "o", "k", "m", "o", "m" });
        public static Stack<string> stackB = new Stack<string>(new string[] { "i", "a", "m", "p", "r", "o", "g", "r", "a", "m", "m", "e", "r" });

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Stack<string> answer = GetFreshStack(stackA, stackB);
            Console.WriteLine(String.Join(" ", answer.ToArray()));
        }
        /* Добавьте свой код ниже */
        public static Stack<string> GetFreshStack(Stack<string> stack1, Stack<string> stack2)
        {
            Stack<string> answer = new Stack<string>();
            List<string> helpfulArr = new List<string>();

            int stack1Count = stack1.Count;
            int stack2Count = stack2.Count;


            for (int i = 0; i < stack2Count; i++)
            {
                helpfulArr.Add(stack2.Pop());
            }

            for (int i = 0; i < stack1Count; i++)
            {
                if (!helpfulArr.Contains(stack1.Peek()) && !answer.Contains(stack1.Peek()))
                {
                    answer.Push(stack1.Pop());
                }
                else
                {
                    stack1.Pop();
                }
            }
            return answer;
        }
    }
}
