using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t20
{
    /*
     * Внутри метода Main() объявлена строка s, содержащая список слов, разделённых определённым символом.
     * Выведите на экран все слова из строки s, которые содержат в себе и цифры, и буквы, каждое с новой строки.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string s = "собачка;котик;123мишка;шишка;лента;123;кристал;полиморф;ксеноморф;шб;крапивка;игрушка;валенок;задача;123123123;красота;1;18й;5алучшевсех;17;квартал;999";
            /* Добавьте свой код ниже */
            string[] words = s.Split(';');
            
            for (int i = 0; i < words.Length; i++) 
            {
                bool checkLetter = false;
                bool checkDigit = false;
                for (int j = 0; j < words[i].Length; j++)
                {
                    if ("абвгдеёжзийклмнопрстуфхцчшщъыьэюя".Contains(words[i][j]))
                    {
                        checkLetter = true;
                    }
                    if ("0123456789".Contains(words[i][j]))
                    {
                        checkDigit = true;
                    }
                }
                if (checkLetter && checkDigit)
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
