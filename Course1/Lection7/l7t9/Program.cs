using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t9
{
    /*
     * Внутри метода Main() создайте новую переменную и присвойте ей словарь, со строковым типом ключа и значения.
     * Добавьте в словарь 5 ваших любимых игрушек из детства и дайте их краткое описание. Выведите на экран
     * содержимое словаря в следующем формате:
     * "Мою игрушку зовут KEY и это: VALUE", где KEY и VALUE это соответствующие элементы словаря.
     * Метод Main() не должен ничего считывать с клавиатуры.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("Tom", "First");
            dict.Add("Benny", "Second");
            dict.Add("Anna", "Third");
            dict.Add("Max", "Fourth");
            dict.Add("Alex", "Fifth");


            Dictionary<string, string>.Enumerator it = dict.GetEnumerator();
            while (it.MoveNext())
            {
                KeyValuePair<string, string> tmp = it.Current;
                Console.WriteLine($"Мою игрушку зовут {tmp.Key} и это: {tmp.Value}");
            }
        }
    }
}
