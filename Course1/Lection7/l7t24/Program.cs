using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t24
{
    /*
     * В  классе Program содержится 5 статических переменных, каждая из которых содержит информацию о какой-то дате.
     * Необходимо изменить метод Main() таким образом, чтобы он выводил каждую из переменных в определенном формате.
     * Формат данных указан в виде комментария напротив соответствующей строки вывода, вся информация там - произвольная!
     * Шаблон задачи изменять нельзя.
     */

    public class Clock
    {
        public static long date1 = 632900149502053008;
        public static long date2 = 612900149502083008;
        public static long date3 = 639900149507083008;
        public static long date4 = 136930149502083008;
        public static long date5 = 536900141502083008;

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(new DateTime(date1).ToString("dd MMMM yyyy г.")); // 07 мая 2018 г.
            Console.WriteLine(new DateTime(date2).ToString("dd MMMM yyyy", CultureInfo.CreateSpecificCulture("en-US")).ToLower()); // 01 may 2018
            Console.WriteLine(new DateTime(date3).ToString("dd.MM.yyyy hh:mm:ss")); // 01.08.2018 01:04:07
            Console.WriteLine(new DateTime(date4).ToString("HH:mm:ss")); // 17:30:30
            Console.WriteLine(new DateTime(date5).DayOfWeek); // Friday
        }
    }
}
