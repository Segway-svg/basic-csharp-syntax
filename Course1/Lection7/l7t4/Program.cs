using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t4
{
    /*
     * В методе Main() удалите из динамического массива arrayList все повторяющиеся элементы, после чего 
     * отсортируйте массив в порядке возрастания и дополните его недостающими элементами так, чтобы получилось
     * непрерывно возрастающее на единицу множество от минимального до максимального элемента массива.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static ArrayList arrayList = new ArrayList() { 1, 5, 6, 7, 6, 8, 9, 10, 2, 5, 7, 9, 15 };

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            for (int i = 0; i < arrayList.Count; i++)
            {
                for (int j = i + 1; j < arrayList.Count; j++)
                {
                    if (Convert.ToInt32(arrayList[i]) == Convert.ToInt32(arrayList[j])) 
                    { 
                        arrayList.Remove(arrayList[j]); 
                        i--; 
                    };
                    
                }
            }
            
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (!arrayList.Contains(i))
                {
                    arrayList.Add(i);
                }
            }
            arrayList.Remove(0);
            arrayList.Sort();

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
    }
}
