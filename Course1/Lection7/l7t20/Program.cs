using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l7t20
{
    /*
     * Внутри метода Main() создайте список строк. Добавьте в созданный список 5 строк, считанных с клавиатуры.
     * Используя цикл foreach найдите самую длинную строку в списке. Выведите самую длинную строку на экран.
     * Если несколько строк имеют одинаковую максимальную длину, выведите каждую с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            List<string> words = new List<string>();
            for (int i = 0; i < 5; i++) words.Add(Console.ReadLine());
            
            List<string> equalWords = new List<string>();
            string answer = "";
            
            foreach (string word in words)
            {
                if (word.Length > answer.Length) answer = word;
            }

            foreach (string word in words)
            {
                if (answer.Length == word.Length) equalWords.Add(word);
            }

            foreach (var word in equalWords) Console.WriteLine(word);
            
        }
    }
}
