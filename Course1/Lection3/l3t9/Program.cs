using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t9
{
    /*
     * Создайте новый класс Ovcharka в том же файле и том же namespace, что и класс Program. 
     * Объявите в классе Ovcharka три целочисленные переменные: age, weight, legsCount. Объявите 
     * в классе Ovcharka две переменные типа строка: name, breed. Подумайте, какие из перечисленных 
     * элементов логично сделать константами, сделайте их константами и присвойте им какие-нибудь 
     * значения по умолчанию.
     */

    public class Program
    {
        public static void Main(string[] args)
        {

        }
    }
    /* Добавьте свой код ниже */
    class Ovcharka
    {
        public const int legsCount = 4;
        public int age = 5;
        public int weight = 10;
        public string name = "Maya";
        public const string breed = "Ovcharka";
    }
}