using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t24
{
    /*
     * Внутри метода Main() объявите новый экземпляр класса Stack и сохраните его в отдельную переменную.
     * Добавьте в Stack 5 строчек, считанных с клавиатуры, после чего выведите на экран все содержимое стека, каждый элемент с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Stack vs = new Stack();
            for (int i = 0; i < 5; i++)
            {
                vs.Push(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vs.Peek()); 
                vs.Pop();
            }
        }
    }
}
