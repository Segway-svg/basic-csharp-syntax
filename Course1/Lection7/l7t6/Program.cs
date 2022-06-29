using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t6
{
    /*
     * Реализуйте класс Cat, он должен:
     *      1) Содержать свойство Id.
     *      2) Содержать конструктор, который принимает один целочисленный параметр и присваивает его свойству.
     *      3) Переопределите метод ToString() так, чтобы он выводил фразу "Я котик и мой id = XXX". XXX - Id экземпляра класса.
     * Внутри метода Main() создайте коллекцию экземпляров класса Cat. Создайте 100 экземпляров класса Cat, а
     * в созданную коллекцию добавьте только котов с четными значениями id.
     * Выведите на экран содержимое коллекции, каждое значение с новой строки. Циклом foreach пользоваться нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            List<Cat> catList = new List<Cat>();
            int count = 0;
            for (int i = 1; i < 101; i++)
            {
                Cat cat = new Cat(i);
                if (i % 2 == 0) 
                {
                    catList.Add(cat);
                }
            }
            for (int i = 0; i < catList.Count; i++)
            {
                Console.WriteLine(catList[i].ToString()); 
            }
        }
    }

    public class Cat
    {
        public int Id { get; set; }
        public Cat(int id)
        {
            Id = id;
        }
        /* Добавьте свой код ниже */
        public override string ToString()
        {
            return $"Я котик и мой id = {Id}";
        }
    }
}
