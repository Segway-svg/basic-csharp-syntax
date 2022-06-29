using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t28
{
    /*
     * Внутри класса Program создайте метод CatNullifier, который должен принимать экземпляр класса Cat и
     * делать так, чтобы он становился недостижимым.
     * Внутри метода Main() вызовите метод CatNullifier для экземпляров cat1 и cat2.
     * Остальные элементы шаблона изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();

            /* Добавьте свой код ниже */
            CatNullifier(ref cat1);
            CatNullifier(ref cat2);

            Console.WriteLine(cat1);
            Console.WriteLine(cat1 == null);
            Console.WriteLine(cat2);
            Console.WriteLine(cat2 == null);
        }
        /* Добавьте свой код ниже */
        public static void CatNullifier(ref Cat cat)
        {
            cat = null;
        }
    }
    public class Cat {}
}
