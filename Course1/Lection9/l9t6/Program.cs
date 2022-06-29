using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t6
{
    /*
     * Внутри метода Main() спровоцировано возникновение исключения. Это одно из самых частых исключений, которое может возникнуть.
     * Перехватите исключение и выведите на экран сведения о нём в следующем формате:
     * "Возникло исключение из namespace: ХХХ! Имя исключения: ХХХ.", где ХХХ - соответствующие сведения о возникшем исключении.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            try
            {
                string s = null;
                Console.WriteLine(s.ToLower());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Возникло исключение из namespace: {e.GetType().Namespace}! Имя исключения: {e.GetType().Name}.");
            }
        }
    }
}
