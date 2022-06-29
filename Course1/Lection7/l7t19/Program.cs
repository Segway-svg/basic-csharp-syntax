using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t19
{
    /*
     * Реализуйте класс Cat, он должен:
     *      1) Содержать свойство Id.
     *      2) Содержать конструктор, который принимает один целочисленный параметр и присваивает его свойству.
     *      3) Переопределите метод ToString() так, чтобы он выводил фразу "Я котик и мой id = XXX". XXX - Id экземпляра класса.
     *      4) Создайте статический метод GetFreshKitties(), который  возвращает 100 экземпляров класса Cat со случайными значениями Id
     * в диапазоне от 1 до 50 включительно.
     * Внутри метода Main() создайте две коллекции экземпляров класса Cat. Пусть первая коллекция содержит в себе результат вызова
     * метода GetFreshKitties(), а вторая содержит перечень экземпляров класса Cat с уникальными ID из первой коллекции.
     * Выведите на экран все элементы второй коллекции, каждое значение с новой строки. Для вывода используйте цикл foreach.
     */
    public class Cat
    {
        public static Random random = new Random();
        public static List<Cat> GetFreshKitties()
        {
        
        List<Cat> listOfCats = new List<Cat>();
        for (int i = 0; i < 100; i++)
        {
            Cat cat = new Cat(random.Next(1, 51));
            listOfCats.Add(cat);
        }
        return listOfCats;
        }

        public int Id { get; set; }

        public Cat(int id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return $"Я котик и мой id = {Id}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            List<Cat> cats1 = new List<Cat>();
            cats1 = Cat.GetFreshKitties();

            List<Cat> cats2 = new List<Cat>();

            List<int> catsId1 = new List<int>();
            List<int> catsId2 = new List<int>();


            for (int i = 0; i < 100; i++)
            {
                catsId1.Add(cats1[i].Id);
            }

            
            for (int i = 0; i < 100; i++)
            {
               if (!catsId2.Contains(catsId1[i]))
               {
                    catsId2.Add(catsId1[i]);
                    cats2.Add(cats1[i]);
               }
            }

            foreach (var cat in cats2)
            {
                Console.WriteLine(cat);
            }
        }
    }
}
