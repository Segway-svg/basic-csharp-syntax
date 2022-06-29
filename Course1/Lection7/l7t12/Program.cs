using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t12
{
    /*
     * Внутри метода Main() создайте программу, которая бы реализовывала следующую логику работы:
     *      1) Создавала и инициализировала список строк.
     *      2) Считывала строки с клавиатуры и помещала бы их в список до тех пор, пока не будет введена
     *      строка "конец".
     *      3) После завершения ввода, выводила бы все строки списка в консоль (каждую с новой строки).
     * Строку "конец", добавлять в список не нужно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            List<string> list = new List<string>();
            bool tmp = true;
            while (tmp)
            {
                string word = Console.ReadLine();
                if (word == "конец") tmp = false;
                else list.Add(word);
            }
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
        }
    }
}
