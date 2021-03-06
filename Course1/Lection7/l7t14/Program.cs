using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t14
{
    /*
     * Внутри метода Main() создайте словарь и заполните его 10 парами ключ-значение, введенными с клавиатуры.
     * Выведите на экран элементы словаря в следующем формате:
     * "key - value", где key и value соответствующие значения элемента словаря.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Dictionary<string, string> map = new Dictionary<string, string>();
            for (int i = 0; i < 10; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                map.Add(key, value);
            }
            Dictionary<string, string>.Enumerator it = map.GetEnumerator();
            while (it.MoveNext())
            {
                KeyValuePair<string, string> tmp = it.Current; 
                Console.WriteLine($"{tmp.Key} - {tmp.Value}");
            }
        }
    }
}
