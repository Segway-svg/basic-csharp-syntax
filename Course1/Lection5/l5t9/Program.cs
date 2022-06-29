using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t9
{
    /*
     * Реализуйте класс Rectangle, который содержит четыре целочисленные переменные - координаты Х вершин прямоугольника.
     * Создайте 5 конструкторов для класса Rectangle.
     */
    public class Rectangle
    {
        /* Добавьте свой код ниже */
        public int x1;
        public int x2;
        public int x3;
        public int x4;

        public Rectangle(int x1)
        {
            this.x1 = x1;
        }

        public Rectangle(int x1, int x2)
        {
            this.x2 = x2;
        }

        public Rectangle(int x1, int x2, int x3)
        {
            this.x3 = x3;
        }

        public Rectangle(int x1, int x2, int x3, int x4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
        }

        public Rectangle()
        {

        }

        public static void Main(string[] args)
        {

        }
    }
}
