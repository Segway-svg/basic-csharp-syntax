using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t10
{
    /*
     * Реализуйте метод MakeTripleString(), который должен принимать в себя список строк и возвращать другой
     * список строк, который бы содержал утроенное количество слов, оканчивающихся на букву "a" из оригинального
     * списка.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "", "арбуз", "собака", "кот", "жабка" };
            foreach (var line in new Program().MakeTripleString(list))
            {
                Console.WriteLine(line);
            }
        }

        public List<string> MakeTripleString(List<string> originalList)
        {
            /* Добавьте свой код ниже */
            List<string> newList = new List<string>();
            for (int i = 0; i < originalList.Count; i++)
            {
                if (originalList[i].Contains('а'))
                {
                    newList.Add(originalList[i]);
                    newList.Add(originalList[i]);
                    newList.Add(originalList[i]);
                }
            }
            return newList;
        }
    }
}
