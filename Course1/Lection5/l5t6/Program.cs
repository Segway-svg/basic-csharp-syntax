using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t6
{
    /*
     * Создайте новый класс Cat в том же файле и том же namespace, что и класс Program. 
     * В классе Cat создайте 6 переменных, имена, типы переменных и модификатор доступа переменных придумайте самостоятельно. 
     * Создайте 7 различных конструкторов для класса Cat.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }
    }
    public class Cat
    {
        public string name;
        public int age;
        public string address;
        public int tailsCount;
        public string colour;
        public string lastName;

        public Cat(string name)
        {
            this.name = name;
        }

        public Cat(int age)
        {
            this.age = age;
        }

        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Cat(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public Cat(int tailsCount, string colour, string lastName)
        {
            this.tailsCount = tailsCount;
            this.colour = colour;
            this.lastName = lastName;
        }

        public Cat(string colour, int tailsCount, string lastName)
        {
            this.tailsCount = tailsCount;
            this.colour = colour;
            this.lastName = lastName;
        }

        public Cat(string colour, string lastName, int tailsCount)
        {
            this.tailsCount = tailsCount;
            this.colour = colour;
            this.lastName = lastName;
        }
    }
}
