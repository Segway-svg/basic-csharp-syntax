using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t4
{
    /*
     * Создайте новый класс Cat в том же файле и том же namespace, что и класс Program.
     * В классе Cat создайте 4 переменные, которые будут отвечать за: имя(name), возраст(age), пол(gender) и владельца кота(owner).
     * Имена, типы переменных и модификатор доступа переменных и классов определите самостоятельно.
     * Создайте конструкторы класса Cat, которые принимают в себя:
     *      1) Имя.
     *      2) Имя и возраст.
     *      3) Имя и возраст и пол.
     * Созданные конструкторы должны инициализировать значениями все переменные класса.
     * Значения для инициализации по умолчанию: возраст - 1; пол - true, владелец - новый экземпляр класса Human.
     */
    public class Human
    {

    }
    public class Cat
    {
        public string name;
        public int age;
        public bool gender;
        public Human owner;
        public Cat(string name)
        {
            this.name = name;
            age = 1;
            gender = true;
            owner = new Human();
        }

        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
            gender = true;
            owner = new Human();
        }

        public Cat(string name, int age, bool gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            owner = new Human();            
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }
    }
}
