using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t4
{
    /*
     * Внутри метода Main() отсортируйте коллекцию objectList в порядке возрастания.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static List<object> objectList = new List<object>() { -1, 5.5, 6, 21.2, -21, 22.3, 6, 7, 23, 8, 2, 9, 2, 99, 101, -9, 5.7 };

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            for (int i = 0; i < objectList.Count; i++)
            {
                for (int j = i + 1; j < objectList.Count; j++)
                {
                    if (Convert.ToDouble(objectList[i]) > Convert.ToDouble(objectList[j])) 
                    {
                        var tmp = objectList[i];
                        objectList[i] = objectList[j];
                        objectList[j] = tmp;
                    }
                }
            }

            foreach (var item in objectList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
