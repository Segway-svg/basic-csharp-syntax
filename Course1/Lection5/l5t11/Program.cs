using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t11
{
    /*
     * Постарайтесь создать для класса Cat как можно больше конструкторов.
     * Шаблон задачи менять нельзя.
     */

    public class Cat
    {
        int age;
        int weight;
        string color;
        string name;

        public Cat()
        {

        }

        public Cat(int age)
        {
            this.age = age;
        }

        public Cat(string color)
        {
            this.color = color;
        }

        public Cat(int age, int weight)
        {
            this.age = age;
            this.weight = weight;
        }

        public Cat(string color, string name)
        {
            this.color = color;
            this.name = name;
        }

        public Cat(int age, string color)
        {
            this.age = age;
            this.color = color;
        }

        public Cat(string color, int age)
        {
            this.age = age;
            this.color = color;
        }

        public Cat(int age, int weight, string color)
        {
            this.age = age;
            this.weight = weight;
            this.color = color;
        }

        public Cat(int age, string color, int weight)
        {
            this.age = age;
            this.weight = weight;
            this.color = color;
        }

        public Cat(string color, int age, int weight)
        {
            this.age = age;
            this.weight = weight;
            this.color = color;
        }

        public Cat(int weight, string color, string name)
        {
            this.weight = weight;
            this.color = color;
            this.name = name;
        }

        public Cat(string color, int weight, string name)
        {
            this.weight = weight;
            this.color = color;
            this.name = name;
        }

        public Cat(string color, string name, int weight)
        {
            this.weight = weight;
            this.color = color;
            this.name = name;
        }

        public Cat(int age, int weight, string color, string name)
        {
            this.age = age;
            this.weight = weight;
            this.color = color;
            this.name = name;
        }

        public Cat(int age, string color, int weight, string name)
        {
            this.age = age;
            this.weight = weight;
            this.color = color;
            this.name = name;
        }

        public Cat(int age, string color, string name, int weight)
        {
            this.age = age;
            this.weight = weight;
            this.color = color;
            this.name = name;
        }

        public Cat(string color, string name, int age, int weight)
        {
            this.age = age;
            this.weight = weight;
            this.color = color;
            this.name = name;
        }

        public Cat(string color, int age, string name, int weight)
        {
            this.age = age;
            this.weight = weight;
            this.color = color;
            this.name = name;
        }

        public Cat(string color, int age,  int weight, string name)
        {
            this.age = age;
            this.weight = weight;
            this.color = color;
            this.name = name;
        }

        /* Добавьте свой код ниже */

        public static void Main(string[] args)
        {
        }
    }
}
