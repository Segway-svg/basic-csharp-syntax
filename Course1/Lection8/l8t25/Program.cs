using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t25
{
    /*
     * Реализуйте класс RichCat, добавив ему целочисленное автоматическое свойство Account, отвечающее за состояние счета экземпляра класса.
     * Добавьте классу RichCat конструктор, принимающий и устанавливающий значение свойства класса.
     * Создайте статический GetModNumber(), который принимает список экземпляров класса RichCat, а возвращает самое большое по модулю значение
     * свойства Account у принятых экземпляров класса.
     */

    public class RichCat
    {
        /* Добавьте свой код ниже */
        public int Account { get; set; }
        public RichCat(int account)
        {
            Account = account;
        }
        
        public static void Main(string[] args)
        {
            List<RichCat> richCats = new List<RichCat>();
            richCats.Add(new RichCat(100));
            richCats.Add(new RichCat(-200));
            richCats.Add(new RichCat(100));
            richCats.Add(new RichCat(100));
            richCats.Add(new RichCat(100));
            Console.WriteLine(GetModNumber(richCats)); 
            
        }
        /* Добавьте свой код ниже */
        public static int GetModNumber(List<RichCat> richCats)
        {
            int max = 0;
            int answer = 0;
            foreach (RichCat richCat in richCats)
            {
                if (Math.Abs(richCat.Account) > max) 
                {
                    max = Math.Abs(richCat.Account); 
                    answer = richCats.IndexOf(richCat); 
                }
            }
            return richCats[answer].Account;
        }
    }
}
