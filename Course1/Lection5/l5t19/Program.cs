using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t19
{
    /*
     * Для класса Dog добавьте следующие переменные:
     *      1) name - отвечающую за имя.
     *      2) speed - отвечающую за скорость.
     *      3) age  - отвечающую за возраст.
     *      4) weight - отвечающую за вес.
     *      5) dogCount - отвечающую за общее количество созданных экземпляров класса Dog.
     * Все переменные сделайте публичными, тип и остальные модификаторы определите самостоятельно.
     * Для класса Dog измените конструктор по умолчанию таким образом, чтобы он:
     *      1) Увеличивал общее количество созданных экземпляров.
     *      2) Присваивал значение равное 1 всем целочисленным переменным класса Dog, относящимся к экземпляру класса.
     */

    public class Dog
    {
        /* Добавьте свой код ниже */
        public string name;
        public int speed;
        public int age;
        public int weight;
        public static int dogCount = 0;

        public Dog()
        {
            this.speed = 1;
            this.age = 1;
            this.weight = 1;
            dogCount++;
        }
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

        }
    }
}
