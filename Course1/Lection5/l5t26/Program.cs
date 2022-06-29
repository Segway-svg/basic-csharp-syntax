using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t26
{
    /*
     * Для класса SpaceDog создайте следующие свойства:
     *      1) Name.
     *      2) Age.
     *      3) IsInSpace.
     *      4) IsGoingToSleep.
     *      5) IsAtHome.
     * Для класса SpaceDog создайте конструктор, который принимает: имя, возраст и статус бодрствования.
     * Свойства IsInSpace и IsAtHome реализуйте таким образом, чтобы они всегда имели противоположные
     * значения.
     * Переопределите метод ToString() для класса SpaceDog, чтобы он выводил информацию об экземпляре в следующем формате:
     * "Меня зовут ХХХ, я первый космонавт! Мне ХХХ лет, я нахожусь дома\в космосе. Я скоро пойду спать\Я недавно проснулся!"
     * Итоговая строка должна зависеть от значений соответствующих свойств экземпляра класса SpaceDog.
     */

    public class SpaceDog
    {
        /* Добавьте свой код ниже */
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsInSpace
        {
            get { return IsInSpace; }
            set 
            { 
                IsInSpace = value;
                IsAtHome = !value;
            }
        }
        public bool IsGoingToSleep { get; set; }
        public bool IsAtHome { 
            get { return IsAtHome; } 
            set 
            {
                IsAtHome = value;
                IsInSpace = !value; 
            }  
        }
        public SpaceDog(string name, int age, bool isGoingToSleep)
        {
            Name = name;
            Age = age;
            IsGoingToSleep = isGoingToSleep;
        }
        public override string ToString()
        {
            string sleep;
            if (IsGoingToSleep == true) sleep = "скоро пойду спать!";
            else sleep = "недавно проснулся!";
            string space;
            if (IsInSpace == true) space = "в космосе.";
            else space = "дома.";

            return $"Меня зовут {Name}, я первый космонавт! Мне {Age} лет, я нахожусь {space} Я {sleep}";
        }


        public static void Main(string[] args)
        {
            SpaceDog spaceDog = new SpaceDog("Name", 12, true);
            Console.WriteLine(spaceDog);
        }

        /* Добавьте свой код ниже */
    }
}
