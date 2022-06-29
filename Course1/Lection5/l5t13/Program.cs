using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t13
{
    /*
     * Реализуйте класс Student таким образом, чтобы он содержал 3 свойства:
     *      1) Имя.
     *      2) Возраст.
     *      3) Кафедра (Cathedra).
     * Добавьте в класс Student конструктор, который принимает имя и возраст, а кафедру укажите любую.
     * Сделайте так, чтобы в случае если переданный возраст объекта был меньше 17 или больше 70, то
     * ему бы присваивалось значение 20, а в остальных случаях - переданное значение.
     */

    public class Student
    {
        /* Добавьте свой код ниже */
        public string Name { get; set; }
        public int Age { get; set; }
        public string Cathedra { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            if (age < 17 || age > 70) Age = 20;
            else Age = age;
            Cathedra = "IT";
        }
        public static void Main(string[] args)
        {

        }
    }
}
