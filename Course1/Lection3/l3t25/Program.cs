using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t25
{
    /*
     * Проанализируйте шаблон, подумайте, почему сейчас программа не компилируется.
     * Расставьте модификаторы доступа так, чтобы программа скомпилировалась и вывела в консоль число 7.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.speed = 3;
            Console.WriteLine(cat.age - cat.speed * cat.id);
        }        
    }

    class Cat
    {
        /* Добавьте свой код ниже */
        internal string name = "Васька";
        public int age = 10;
        public int speed = 7;
        public int id = 1;
    }
}
