﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t21
{
    /*
     * Внутри метода Main() объявлено две переменных: cat и dog, каждой из них присвоены ссылки на соответствующие экземпляры классов.
     * Внутри метода Main():
     *      1) Создайте две целочисленные переменные: catInt и dogInt.
     *      2) Для переменной catInt присвойте значение переменной catNumber класса Cat.
     *      3) Для переменной dogInt присвойте значение переменной dogNumber класса Dog.
     * Выведите на экран квадрат разности переменных catInt и dogInt.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            /* Добавьте свой код ниже */
            int catInt = cat.catNumber;
            int dogInt = dog.dogNumber;
            Console.WriteLine(catInt * catInt - 2 * catInt * dogInt + dogInt * dogInt);
        }
    }

    class Cat
    {
        public int catNumber = 8 / 2 + 127 + 17 * 27 / 7;
    }

    class Dog
    {
        public int dogNumber = 19 * 12 / 3 + 123 / 5;
    }
}
