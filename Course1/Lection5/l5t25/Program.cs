using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t25
{
    /*
     * Для класса Program создайте:
     *      1) 3 произвольных автоматических свойства, доступные только на чтение.
     *      2) 2 произвольных автоматических свойства, доступные только на запись.
     * Тип, модификаторы и имена свойств придумайте самостоятельно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Address { get; private set; }

        public int Number { private get; set; }
        public int Aboba { private get; set; }

    }
}
