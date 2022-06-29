using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t22
{
    /*
     * Для всех приватных полей класса Flower реализуйте сеттеры и геттеры.
     * Шаблон задачи изменять нельзя.
     */

    public class Flower
    {
        private string color = "NoColor";
        private string title = "NoTitle";

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public string GetColor()
        {
            /* Добавьте свой код ниже */
            return color;
            
        }
        public void SetColor(string color)
        {
            /* Добавьте свой код ниже */
            this.color = color;
        }
        public string GetTitle()
        {
            /* Добавьте свой код ниже */
            return title;
        }
        public void SetTitle(string title)
        {
            /* Добавьте свой код ниже */
            this.title = title;
        }
    }
}
