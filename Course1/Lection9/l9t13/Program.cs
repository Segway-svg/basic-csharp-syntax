using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t13
{
    /*
     * Внутри метода Main() для каждого элемента в списке dateStrings извлеките значения даты
     * и выведите их на экран в следующем формате: "день-=-месяц-=-год".
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> dateStrings = new List<string>() { "11.11.2011", "11.10.2001", "12.12.2012", "01.01.3000", "31.12.2019" };
            /* Добавьте свой код ниже */
            string days = "";
            string month = "";
            string year = "";


            for (int i = 0; i < dateStrings.Count; i++)
            {
                days += dateStrings[i][0];
                days += dateStrings[i][1];
                month += dateStrings[i][3];
                month += dateStrings[i][4];
                for (int j = 6; j < dateStrings[i].Length; j++)
                {
                    year += dateStrings[i][j];
                }
                Console.WriteLine($"{days}-=-{month}-=-{year}");
                days = "";
                month = "";
                year = "";
            }
        }
    }
}
