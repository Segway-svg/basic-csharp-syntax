using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t18
{
    /*
     * Внутри метода Main() объявлена строка s, содержащая список слов, разделённых определённым символом. 
     * Выведите на экран все слова, содержащиеся в строке s, каждое с новой строки.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string s = "собачка,котик,мишка,шишка,лента,кристал,полиморф,ксеноморф,шб,крапивка,игрушка,валенок,задача,красота,звезда,полигон,Линейка,%,телефон,помощь,гугл";
            /* Добавьте свой код ниже */
            string word = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ',')
                {
                    Console.WriteLine(word);
                    word = "";
                    continue;
                }
                if (i == s.Length - 1)
                {
                    word += s[i]; 
                    Console.WriteLine(word);
                }
                word += s[i];
            }
        }
    }
}
