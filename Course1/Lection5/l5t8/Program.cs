using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t8
{
    /*
     * Реализуйте перечисление MyFavoritePets, которое должно содержать как минимум 4 элемента, 
     * каждый из которых должен олицетворять названия ваших любимых домашних животных.
     * Реализуйте класс Animal, который должен содержать:
     *      1) Четыре поля класса: возраст, вес, скорость и тип.
     *      2) 1 конструктор, который принимает только тип животного.
     * Конструктор класса, должен инициализировать все недостающие поля класса, на основе переданного типа.
     * Все инициализированные в конструкторе поля класса должны иметь значения, отличные от значений по умолчанию.
     * Все элементы класса должны быть публичными.
     */
    public class Animal
    {
        /* Добавьте свой код ниже */
        public int age;
        public int weight;
        public int speed;
        public MyFavoritePets type;
        public Animal(MyFavoritePets type)
        {
            this.type = type;
            switch (type)
            {
                case MyFavoritePets.Lion:
                    age = 15;
                    weight = 70;
                    speed = 100;
                    break;
                case MyFavoritePets.Cat:
                    age = 10;
                    weight = 3;
                    speed = 10;
                    break;
                case MyFavoritePets.Dog:
                    age = 6;
                    weight = 5;
                    speed = 20;
                    break;
                case MyFavoritePets.Mouse:
                    age = 1;
                    weight = 1;
                    speed = 3;
                    break;
            }
        }
        public static void Main(string[] args)
        {            
        }
    }

    public enum MyFavoritePets
    {
        /* Добавьте свой код ниже */
        Lion = 1,
        Cat,
        Dog,
        Mouse
    }
}
