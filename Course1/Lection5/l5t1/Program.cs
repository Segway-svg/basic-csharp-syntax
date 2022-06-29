using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t1
{

    /*
     * Создайте новый публичный класс Dog в том же файле и том же namespace, что и класс Program. 
     * Объявите в классе Dog три переменные: name,age,breed, тип и модификатор доступа переменных определите самостоятельно. 
     * Переопределите метод ToString() для класса Dog так, чтобы он выводил информацию об экземпляре класса в следующем формате: 
     * "Привет!!! Я собачка и меня зовут ХХХ!!! Мне ХХХ лет и я отношусь к породе: ХХХ!". 
     * ХХХ - значения соответствующих переменных класса Dog. 
     * Внутри метода Main() создайте 4 экземпляра класса Dog используя статическую инициализацию и выведите в консоль информацию 
     * по созданным экземплярам, каждый экземпляр с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Dog albert = new Dog { age = 5, breed = "Овчарка", name = "Альберт"};
            Dog muhtar = new Dog { age = 10, breed = "Шпиц", name = "Мухтар"};
            Dog stas = new Dog { age = 12, breed = "Доберман", name = "Стэс"};
            Dog aboba = new Dog { age = 6, breed = "Мопс", name = "Абоба"};
            Console.WriteLine(albert);
            Console.WriteLine(muhtar);
            Console.WriteLine(stas);
            Console.WriteLine(aboba);

        }
    }
    /* Добавьте свой код ниже */
    public class Dog
    {
        public string name;
        public int age;
        public string breed;

        public override string ToString()
        {
            return $"Привет!!! Я собачка и меня зовут {name}!!! Мне {age} лет и я отношусь к породе: {breed}!";
        }
    }
}
