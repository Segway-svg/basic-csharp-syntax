using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t5
{
    /*
     * Создайте класс Cat с публичной статической переменной allCats. Реализуйте класс Cat таким образом,
     * чтобы при создании каждого экземпляра класса Cat, он попадал в переменную allCats.
     * Внутри метода Main() создайте 10 экземпляров класса Cat. Выведите на экран содержимое переменной
     * allCats, каждое значение с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Cat cat3 = new Cat();
            Cat cat4 = new Cat();
            Cat cat5 = new Cat();
            Cat cat6 = new Cat();
            Cat cat7 = new Cat();
            Cat cat8 = new Cat();
            Cat cat9 = new Cat();
            Cat cat10 = new Cat();

            List<Cat>.Enumerator it = Cat.allCats.GetEnumerator();
            while (it.MoveNext())
            {
                Console.WriteLine(it.Current);
            }
        }
    }
    /* Добавьте свой код ниже */
    public class Cat
    {
        public static List<Cat> allCats = new List<Cat>();
        public Cat()
        {
            allCats.Add(this);
        }
    }
}




