using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t17
{
    /*
     * Добавьте в класс Program статический метод Add(), который принимает один строковый параметр, 
     * выводит в консоль 1 раз переданный параметр, а возвращает переданный параметр трижды, склеенный с самим собой. 
     * Тип возвращаемого значения определите сами. 
     * Внутри метода Main() вызовите метод Add и передайте ему введённую с клавиатуры строку, сохраните результат 
     * этого вызова в отдельную переменную и выведите её на экран.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            string answer = Add(Console.ReadLine());
            Console.WriteLine(answer);
        }
        /* Добавьте свой код ниже */
        static string Add(string word)
        {
            Console.WriteLine(word);
            return word + word + word;
        }
    }
}
