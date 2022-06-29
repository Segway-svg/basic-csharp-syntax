using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t15
{
    /*
     * Добавьте в класс Program статический метод Square(), который принимает один целочисленный параметр, а возвращает квадрат переданного параметра. 
     * Тип возвращаемого значения метода Square() определите самостоятельно. 
     * Внутри метода Main() вызовите метод Square() и передайте ему введенное с клавиатуры число. 
     * Выведите на экран результат работы метода Square().
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Square(a));
        }
        /* Добавьте свой код ниже */
        static int Square(int a)
        {
            return a * a;
        }
    }
}
