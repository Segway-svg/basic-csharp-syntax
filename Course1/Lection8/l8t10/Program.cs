using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t10
{
    /*
     * Создайте статический метод GetCharDictionary(), который:
     *      1) Принимает строку в качестве входящего параметра.
     *      2) Возвращает словарь, где ключи - все символы принятой строки, а значения - количество повторений данных символов.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            foreach (KeyValuePair<char, int> keyValuePair in GetCharDictionary("ABOBA"))
                Console.WriteLine(keyValuePair.Key + " " + keyValuePair.Value);
        
        }

        public static Dictionary<char, int> GetCharDictionary(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            
            for (int i = 0; i < str.Length; i++)
            {
                if (!dict.ContainsKey(str[i]))
                    dict.Add(str[i], 1);
                else dict[str[i]]++;
            }
            return dict;
        }
    }
}
