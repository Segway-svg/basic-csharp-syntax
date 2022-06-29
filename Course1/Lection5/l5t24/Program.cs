using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t24
{
    /*
     * Измените класс Program таким образом, чтобы вместо публичных переменных класса, класс стал использовать
     * автоматические свойства, с соответствующими именами. Ненужные переменные - удалите.
     * Остальные элементы шаблона изменять нельзя.
     */

    public class Program
    {
        public int version;
        public string name;
        public Human owner;
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }
        public int Version 
        { 
        get { return version; }
            set
            {
                this.version = value;
            }
                }

        public string Name { get; set; }

        public Human Owner { get; set; }
    }

    public class Human
    {
        public string name;
    }
}
