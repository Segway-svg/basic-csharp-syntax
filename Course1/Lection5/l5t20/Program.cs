using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t20
{
    /*
     * Создайте публичный класс Human в том же файле и namespace, что и класс Animal.
     * Для класса Animal объявите следующие переменные:
     *      1) name - отвечающую за имя.
     *      2) speed - отвечающую за скорость.
     *      3) age - отвечающую за возраст.
     *      4) owner - отвечающую за владельца.
     * Для класса Human объявите следующие переменные:
     *      1) name -  отвечающую за имя.
     *      2) age - отвечающую за возраст.
     * Все переменные классов должны быть публичными, тип и остальные модификаторы определите самостоятельно.
     * Для класса Animal объявите конструктор, который:
     *      1) Принимает имя, скорость, возраст и владельца животного, инициализируя соответствующие поля класса.
     *      2) Всегда присваивает значение имени с заглавной буквы.
     *      3) Присваивает значение "Кеша" имени экземпляра, если получена пустая строка с именем.
     *      4) Присваивает значение 7 возрасту экземпляра, если получено отрицательное или равное 0 значение с возрастом.
     *      5) Присваивает значение 121 скорости экземпляра, если получено отрицательное или равное 0 значение со скоростью.
     *      6) Присваивает новый экземпляр класса Human переменной owner с произвольным именем, если имя владельца "Аноним".
     * Возраст владельца при этом должен остаться без изменений.
     * Для класса Human объявите конструктор, который:
     *      1) Принимает имя и возраст, инициализируя соответствующие поля класса.
     *      2) Всегда присваивает значение имени с заглавной буквы.
     *      3) Присваивает значение "Аноним" имени экземпляра, если получена пустая строка с именем.
     */
    public class Animal
    {
        /* Добавьте свой код ниже */
        public string name;
        public int speed;
        public int age;
        public Human owner;
        public Animal(string name, int speed, int age, Human owner)
        { 
            if (name == "") this.name = "Кеша";
            else this.name = name.Substring(0, 1).ToUpper() + name.Remove(0, 1).ToLower();
            if (age <= 0) this.age = 7;
            else this.age = age;
            if (age <= 0) this.speed = 121;
            else this.speed = speed;
            if (owner.name == "Аноним") this.owner = new Human("Анатолий", owner.age);
            else this.owner = owner;
            //this.owner.name = owner.name;
        }
        //public override string ToString()
        //{
        //    return $"Животное. Имя: {name}. Возраст: {age}. Скорость: {speed}. Хозяин: {owner}";
        //}


        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            //Animal animal = new Animal("Барсик", 12, 8, new Human("Сергей", 20));
            //Console.WriteLine(animal);
            //Console.WriteLine(animal.owner.name);

            //Animal animal1 = new Animal("барсик", 0, -2, new Human("", 20));
            //Console.WriteLine(animal1);
            //Console.WriteLine(animal1.owner.name);
            //Console.WriteLine(animal1.owner.age);
        }
    }

    /* Добавьте свой код ниже */
    public class Human
    {
        public string name;
        public int age;
        public Human(string name, int age)
        {
            if (name == "") this.name = "Аноним";
            else this.name = name.Substring(0, 1).ToUpper() + name.Remove(0, 1).ToLower();
            this.age = age;
        }
        //public override string ToString()
        //{
        //    return $"Хозяин. Имя: {name}. Возраст: {age}";
        //}
    }
}
