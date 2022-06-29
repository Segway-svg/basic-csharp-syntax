using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t15
{
    /*
     * Внутри метода Main() считайте с клавиатуры текстовую строку, после чего выведите на экран две строки:
     *      1) Первая содержит только гласные буквы из введенной строки.
     *      2) Вторая содержит только согласные буквы и знаки препинания из введённой строки.
     * Символы в первой и второй строке должны быть выведены через пробел.
     * =====================================================================================================
     *      Учитывается только русский алфавит. Регистр букв имеет значение!
     *      К знакам препинания в том числе относятся следующие символы: ! ( ) ? " -
     * =====================================================================================================
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            string str = Console.ReadLine();

            string answer1 = "";
            string answer2 = "";

            List<char> symbols = new List<char>() { 'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р',
             'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', '.', ',', ':', ';', '!', '?', '(', ')', '-', '"'};

            for (int i = 0; i < str.Length; i++)
            {
                if ("аеёиоуыэюя".Contains(str[i].ToString().ToLower()))
                {
                    answer1 += str[i];
                }
                if (symbols.Contains(Convert.ToChar(str[i].ToString().ToLower())))
                {
                    answer2 += str[i];
                }
            }

            for (int i = 0; i < answer1.Length; i++)
            {
                if (i == answer1.Length - 1)
                {
                    Console.WriteLine(answer1[i]);
                    break;
                }
                Console.Write(answer1[i] + " ");
            }

            for (int i = 0; i < answer2.Length; i++)
            {
                if (i == answer2.Length - 1)
                {
                    Console.WriteLine(answer2[i]);
                    break;
                }
                Console.Write(answer2[i] + " ");
            }
        }
    }
}
