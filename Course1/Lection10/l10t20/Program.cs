using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t20
{
    /*
     * Реализуйте метод MagicReverse(), который:
     *      1) Должен возвращать принятую строку, записанную в обратном порядке, если строка заканчивается гласной буквой.
     *      2) Должен возвращать принятую строку, записанную символами с обратными регистром, если строка заканчивается согласной буквой.
     *      3) Если строка не заканчивается буквой, то она должна быть возвращена без изменения.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MagicReverse("Красота"));
            Console.WriteLine(MagicReverse("КоТ"));
            Console.WriteLine(MagicReverse("Победа!"));
            Console.WriteLine(MagicReverse("ЗаМоК"));
            Console.WriteLine(MagicReverse("Яизенма"));
        }

        public static string MagicReverse(string s)
        {
            /* Добавьте свой код ниже */
            char letter = s[s.Length - 1];
            if ("аеёиоуыэюя".Contains(letter.ToString().ToLower()))
            {
                char[] reversed = s.ToCharArray();
                Array.Reverse(reversed);
                return new string(reversed);
            }
            else if ("бвгджзйклмнпрстфхцчшщ".Contains(letter.ToString().ToLower()))
            {
                char[] chars = s.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i].ToString().ToLower() == chars[i].ToString())
                    {
                        chars[i] = Char.ToUpper(chars[i]);
                    }
                    else
                    {
                        chars[i] = Char.ToLower(chars[i]);
                    }
                }
                return new string(chars);
            }
            return s;
        }
    }
}
