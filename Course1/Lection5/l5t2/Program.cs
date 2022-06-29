using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t2
{
    /*
     * Создайте новый публичный класс Bird в том же файле и том же namespace, что и класс Program. 
     * Объявите в классе Bird четыре переменные: name, age, breed, continent. 
     * Переменная continent должна являться публичным перечислением, содержащим все существующие на текущий момент континенты.
     * Перечисление должно быть объявлено в том же файле и том же namespace, что и класс Program.
     * Тип и модификатор доступа остальных переменных определите самостоятельно. 
     * Переопределите метод ToString() для класса Bird так, чтобы он выводил информацию об экземпляре класса в следующем формате: 
     * "Привет!!! Я птичка и меня зовут ХХХ!!! Мне ХХХ лет и я отношусь к породе: ХХХ, которая водится на континенте: ХХХ!".
     * ХХХ - значения соответствующих переменных класса Bird. 
     * Внутри метода Main() создайте 2 экземпляра класса Bird используя статическую инициализацию и выведите в консоль информацию 
     * по созданным экземплярам, каждый экземпляр с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Bird bird1 = new Bird { age = 2, breed = "папуг", name = "Кеша", continent = Continent.Europe};
            Console.WriteLine(bird1);
            Bird bird2 = new Bird { age = 1, breed = "воробей", name = "Борис", continent = Continent.Asia};
            Console.WriteLine(bird2);
        }
    }
    /* Добавьте свой код ниже */
    public enum Continent
    {
        Europe,
        Asia,
        Africa,
        Antarctica,
        Australia,
        NorthAmerica,
        SouthAmerica
    }
    public class Bird
    {
        public string name;
        public int age;
        public string breed;
        public Continent continent;

        public override string ToString()
        {
            return $"Привет!!! Я птичка и меня зовут {name}!!! Мне {age} лет и я отношусь к породе: {breed}, которая водится на континенте: {continent}!";
        }
    }
}
