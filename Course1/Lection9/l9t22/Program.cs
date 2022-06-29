using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t22
{
    /*
     * Внутри метода Main() дана строка s. Необходимо программно:
     *      1) Заменить все символы 1 на буквы o.
     *      2) Заменить все символы 2 на буквы и.
     *      3) Заменить все символы 3 на буквы к.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string s = "31т232 – 31т232 – 31т232 бегем1т232!";
            /* Добавьте свой код ниже */
            for (int i = 0; i < s.Length; i++)
            {
                StringBuilder sb = new StringBuilder(s);
                switch (s[i])
                {
                    case '1':
                        sb[i] = 'о';
                        break;
                    case '2':
                        sb[i] = 'и';
                        break;
                    case '3':
                        sb[i] = 'к';
                        break;
                }
                s = sb.ToString();
            }
            Console.WriteLine(s);
        }
    }
}
