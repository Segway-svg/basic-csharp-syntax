using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t21
{
    /*
     * Внутри класса Program создайте и реализуйте метод Encrypt(), который будет отвечать за шифрование строк по методу Цезаря.
     * Метод Encrypt() должен:
     *      1) Принимать в качестве входящего параметра:
     *        - строку, подлежащую шифрованию;
     *        - целое положительное число, отвечающее за шаг сдвига;
     *        - логический параметр, отвечающий за направление сдвига (true - положительное, false - отрицательное).
     *      2) Возвращать шифрованную строку по методу Цезаря, с учетом следующих особенностей шифрования:
     *        - сдвигу подвергаются только символы русского алфавита;
     *        - пробелы, знаки препинаний и иностранные символы не должны изменяться.
     * Шаблон задачи изменять нельзя.
     * P.S. Не забудьте, что в русском алфавите 33 буквы, но индекс первой буквы следует начинать с нуля!
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Encrypt("Дружище!!!", 3, true));
            Console.WriteLine(Encrypt("Как мне кажется, первый курс и основы синтаксиса .Net тобой изучены отлично!", 6, false));
            Console.WriteLine(Encrypt("Осталось чуть-чуть и ты будешь на шаг ближе к своей мечте!", 3, true));
        }

        /* Добавьте свой код ниже */
        public static string Encrypt(string str, uint num, bool step)
        {
            string alphabet = "";
            char[] sentence = str.ToCharArray();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i].ToString().ToLower() == sentence[i].ToString())
                {
                    alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                }
                else
                {
                    alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
                }

                if (alphabet.Contains(sentence[i]))
                {
                    if (!step)
                    {
                        if (alphabet.IndexOf(sentence[i].ToString()) - num < 0)
                        {
                            int additionalNum = 32 - (int)(num - alphabet.IndexOf(sentence[i].ToString()) - 1);
                            sentence[i] = alphabet[additionalNum];
                        }
                        else
                        {
                            sentence[i] = alphabet[alphabet.IndexOf(sentence[i].ToString()) - (int)num];
                        }
                    }
                    else
                    {
                        if (alphabet.IndexOf(sentence[i].ToString()) + num > 32)
                        {
                            int additionalNum = (int)(alphabet.IndexOf(sentence[i].ToString()) + num - 1 - 32);
                            sentence[i] = alphabet[additionalNum];
                        }
                        else
                        {
                            sentence[i] = alphabet[alphabet.IndexOf(sentence[i].ToString()) + (int)num];
                        }
                    }
                }
            }
            string answer = new string(sentence);
            return answer;
        }
    }
}
