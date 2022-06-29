using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t19
{
    /*
     * Внутри метода Main() объявлена строка s, содержащая список слов, разделённых определённым символом.
     * Выведите на экран все слова из строки s, которые содержат в себе только цифры. Все найденные слова выведите
     * одной строкой через пробел. Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string s = "собачка;котик;123мишка;шишка;лента;123;кристал;полиморф;ксеноморф;шб;крапивка;игрушка;валенок;задача;123123123;красота;1;18й;5алучшевсех;17;квартал;999";
            /* Добавьте свой код ниже */
            string[] words = s.Split(';');
            foreach (string word in words)
            {
                bool check = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (!"0123456789".Contains(word[i])) { check = false; }
                }
                if (check)
                {
                    if (word == words.Last())
                    {
                        Console.Write(word);
                        break;
                    }
                    Console.Write(word + " ");
                }
            }
        }
    }
}
