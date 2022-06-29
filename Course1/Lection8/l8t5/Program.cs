using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t5
{
    /*
     * Реализуйте публичный класс CreditCard, который должен:
     *      1) Содержать публичное целочисленное свойство DollarsCount.
     *      2) Содержать публичное целочисленное свойство CentsCount.
     *      3) Конструктор класса, который принимает 1 число с плавающей запятой, где целая часть - количество долларов, а
     * дробная часть - количество центов на счете и устанавливает соответствующие значения свойствам класса.
     * Если переданное число имеет больше 2-х значимых чисел после запятой - его необходимо округлить до двух знаков после запятой.
     * Добавьте классу CreditCard статический метод CardInfo(), который:
     *      1) Принимает экземпляр класса CreditCard.
     *      2) Ничего не возвращает.
     *      3) Выводит в консоль информацию о состоянии текущего баланса в формате: "На карте мистера Кота ХХХ долларов и YYY центов".
     */

    public class CreditCard
    {
        /* Добавьте свой код ниже */
        public int DollarsCount { get; set; }
        public int CentsCount { get; set; }
        public CreditCard(double num)
        {
            num = Math.Round(num, 2);
            string intNumToConvert = "";
            string doubleNumToConvert = "";
            for (int i = 0; i < num.ToString().Length; i++)
            {
                if (num.ToString()[i] != ',') intNumToConvert += num.ToString()[i];
                else
                {
                    i++;
                    while (i != num.ToString().Length)
                    {
                        doubleNumToConvert += num.ToString()[i];
                        i++;
                    }
                }
            }
            DollarsCount = Convert.ToInt32(intNumToConvert);
            CentsCount = Convert.ToInt32(doubleNumToConvert);
        }

        public static void CardInfo(CreditCard creditCard)
        {
            Console.WriteLine($"На карте мистера Кота {creditCard.DollarsCount} долларов и {creditCard.CentsCount} центов");
        }
        public static void Main(string[] args)
        {
            CreditCard creditCard = new CreditCard(25.555);
            CardInfo(creditCard);
        }
    }
}
