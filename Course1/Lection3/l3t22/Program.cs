using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t22
{
    /*
     * Внутри метода Main() объявлено 2 переменных: catNumber, dogNumber. Вам необходимо внутри метода Main():
     *      1) Переменной catNumber присвоить значение переменной catSpeed.
     *      2) Переменной dogNumber присвоить значение переменной dogSpeed.   
     * Выведите на экран куб суммы переменных catSpeed и dogSpeed.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            int catNumber;
            int dogNumber;
            /* Добавьте свой код ниже */
            catNumber = Cat.catSpeed;
            Dog dog = new Dog();
            dogNumber = dog.dogSpeed;
            Console.WriteLine(catNumber * catNumber * catNumber + 3 * catNumber * catNumber
                * dogNumber + 3 * catNumber * dogNumber * dogNumber + dogNumber * dogNumber * dogNumber);
        }
    }

    class Cat
    {
        public static int catSpeed = -77 * 192 / 27 + 123 - 1761 / 90 + 18;
    }

    class Dog
    {
        public int dogSpeed = 872 / 23 * 17 + 123 - 18 - 512;
    }
}