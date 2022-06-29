using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace l6t19
{
    /*
     * Реализуйте статический метод WordSorter() который:
     *      1) Принимает строку произвольной длины.
     *      2) Формирует и возвращает новую строку так, чтобы буквы каждого слова принятой строки были отсортированы по алфавиту.
     *      3) Если слово содержит буквы не русского алфавита или цифры - оно должно остаться без изменения.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string s1 = "Красивая строка с1223 123";
            string s2 = "Один два три";
            string s3 = "Арбу3";
            Console.WriteLine(WordSorter(s1));
            Console.WriteLine(WordSorter(s2));
            Console.WriteLine(WordSorter(s3));
        }

        public static string WordSorter(string word)
        {
            /* Добавьте свой код ниже */
            var arr = word.Split(' ');
            string answer = "";

            foreach (var item in arr)
            {
                bool isCorrect = true;
                foreach (var ch in item)
                {
                    if (!(Char.ToLower(ch) >= 'а' && Char.ToLower(ch) <= 'я' || Char.ToLower(ch) == 'ё'))
                    {
                        isCorrect = false;
                    }
                }

            List<char> chars = new List<char>(item.ToCharArray());
                
            if (isCorrect == true)
            {
                for (int i = 0; i < chars.Count; i++)
                {
                    for (int j = i + 1; j < chars.Count; j++)
                    {
                        if (Char.ToLower(chars[i]) > Char.ToLower(chars[j]))
                        {
                            var tmp = chars[i];
                            chars[i] = chars[j];
                            chars[j] = tmp;
                        }
                    }
                }
            }
            string outString = new string(chars.ToArray());
            answer += outString + " ";
            }
            return answer.Substring(0, answer.Length - 1);
        }
    }
}
