using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t18
{
    /*
     * Создайте метод MagicMovement(), который должен:
     *      1) Принимать строку в качестве входящего параметра.
     *      2) Если принятая строка содержит нечетное количество символов: возвращать строку которая содержит все символы принятой строки в обратном порядке.
     *      3) Если принятая строка содержит четное количество символов: возвращать строку, где четные и нечетные символы принятой строки поменяны местами.
     *      4) Если принята пустая строка: возвращать строку "Принята пустая строка".
     *      5) Если принято пустое значение: возвращать строку "Null и пустая строка не одно и тоже".
     */

    public class Program
    {
        public static void Main(string[] args)
        {
        }

        /* Добавьте свой код ниже */
        public string MagicMovement(string str)
        {
            if (str == null)
            {
                return "Null и пустая строка не одно и тоже";
            }
            if (str.Equals(""))
            {
                return "Принята пустая строка";
            }
            if (str.Length % 2 != 0)
            {
                return new string(str.Reverse().ToArray());
            }
            else
            {
                StringBuilder sb = new StringBuilder(str);
                
                for (int i = 0; i < sb.Length; i += 2)
                {
                    var tmp = sb[i];
                    sb[i] = sb[i + 1];
                    sb[i + 1] = tmp; 
                }
                str = sb.ToString();
                return str;
            }
        }
    }
}
