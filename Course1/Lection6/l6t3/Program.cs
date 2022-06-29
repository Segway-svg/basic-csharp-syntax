using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t3
{
    /*
     * Пусть у каждой кошки есть имя, кошка-папа(fatherCat) и кошка-мама(motherCat).
     * Создайте класса Cat, который бы описывал данную ситуацию, все поля класса - публичные.
     * Внутри метода Main() создайте 8 экземпляров класса Cat, каждый в своей переменной, 
     * которые бы описывали следующую кошачью семью:
     *      1) Кота-дедушку по маме(не имеет родителей).
     *      2) Кота-бабушку по маме(не имеет родителей).
     *      3) Кота-дедушку по папе(не имеет родителей).
     *      4) Кота-бабушку по папе(не имеет родителей).
     *      5) Кота-маму.
     *      6) Кота-папу.
     *      7) Двух котят.
     * Переопределите метод ToString() класса Cat, так чтобы он выводил информацию в следующем формате:
     * "Имя: ХХХ"
     * "Имя кота-мамы: ХХХ"
     * "Имя кота-папы: ХХХ"
     * "Имена бабушек: ХХХ,XXX"
     * "Имена дедушек: ХХХ,XXX"
     * Для класса Cat создайте конструктор, который принимает имя и два родительских объекта.
     * Внутри метода Main() выведите в консоль информацию о двух котятах. Все элементы класса Cat должны быть публичными.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Cat catMomsFather = new Cat("Папа мамы", null, null);
            Cat catMomsMother = new Cat("Мама мамы", null, null);
            Cat catFathersFather = new Cat("Папа папы", null, null);
            Cat catFathersMother = new Cat("Мама папы", null, null);

            Cat catMother = new Cat("Мама", catMomsFather, catMomsMother);
            Cat catFather = new Cat("Папа", catFathersFather, catFathersMother);
            Cat kitten1 = new Cat("Китик", catFather, catMother);
            Cat kitten2 = new Cat("Китик", catFather, catMother);


            Console.WriteLine(kitten1);
            Console.WriteLine(kitten2);
        }
    }
    public class Cat
    {
        public string name;
        public Cat fatherCat;
        public Cat motherCat;

        public Cat(string name, Cat fatherCat, Cat motherCat)
        {
            this.name = name;
            this.fatherCat = fatherCat;
            this.motherCat = motherCat;
        }

        public override string ToString()
        {
            return $"Имя: {name}\nИмя кота-мамы: {motherCat.name}\nИмя кота-папы: {fatherCat.name}\nИмена бабушек: {motherCat.motherCat.name},{fatherCat.motherCat.name}\nИмена дедушек: {fatherCat.fatherCat.name},{motherCat.fatherCat.name}";
        }
    }
}
