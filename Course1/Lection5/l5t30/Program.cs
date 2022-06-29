using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t30
{
    /*
     * Реализуйте класс Bird таким образом, чтобы:
     *      1) Он имел 3 автоматических свойства: Name, Age, Speed.
     *      2) Свойства Age и Speed имели стартовые значения равные 100.
     * Добавьте в класс Bird публичный метод ChangeObject(), который:
     *      1) Принимает строку-имя в качестве входящего параметра.
     *      2) Устанавливает значение Age равное 50, если полученная строка начинается с заглавной буквы.
     *      3) Устанавливает значение Speed 10, если полученная строка заканчивается заглавной буквой.
     *      4) Умножает значение Age на 2, если полученная строка заканчивается цифрой.
     */

    public class Bird
    {
        /* Добавьте свой код ниже */
        public string Name { get; set; }
        public int Age { get; set; }
        public int Speed { get; set; }
        public Bird()
        {
            Speed = 100;
            Age = 100;
        }
        public void ChangeObject(string name)
        {
            Name = name;
            if (name.Substring(0, 1) == name.Substring(0, 1).ToUpper()) Age = 50;
            if (char.IsUpper(name[name.Length - 1])) Speed = 10;
            for (int i = 0; i < 10; i++)
            {
                if (Convert.ToInt32(name[name.Length - 1] - 48) == i) Age *= 2;
            }
        }
        public override string ToString()
        {
            return $"Age: {Age}, Name: {Name}, Speed: {Speed}";
        }

        public static void Main(string[] args)
        {
            //string name = "boA";
            //int speed = 0;
            //if (name.Substring(0, 1) == name.Substring(0, 1).ToUpper()) speed = 50;
            //if (name[name.Length - 1].ToString() == name[name.Length - 1].ToString().ToUpper()) speed = 10;
            //Console.WriteLine(speed);
        }
    }
}
