using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t5
{
    /*
     * Реализуйте класс Dog таким образом, чтобы он мог инициализироваться при помощи следующих конструкторов:
     *      1) Имя.
     *      2) Имя, вес и возраст.
     *      3) Имя и возраст.
     *      4) Вес, цвет.
     *      5) Вес, цвет и адрес.
     * Защитите класс Dog от создания "бесполезных" экземпляров класса, определите обязательные значения и 
     * инициализируйте их произвольными значениями в каждом из созданных конструкторов.
     * Все элементы класса должны быть публичными.
     */

    public class Dog
    {
        /* Добавьте свой код ниже */
        public string name;
        public int weight;
        public int age;
        public string color;
        public string address;
        public Dog(string name)
        {
            this.name = name;
            age = 1;
            weight = 1;
        }
        public Dog(string name, int weight, int age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
        }
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            weight = 1;
        }

        public Dog(int weight, string color)
        {
            this.weight = weight;
            this.color = color;
            age = 1;
        }

        public Dog(int weight, string color, string address)
        {
            this.weight = weight;
            this.color = color;
            this.address = address;
            age = 1;
        }

        public static void Main(string[] args)
        {
            
            
        }
    }
   
}
